namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context) => _context = context;

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            /*
                * Include(p => p.Variants) говорит EF получить не только основные данные о продукте, но и связанные данные 
                  о вариантах этого продукта. Вместо по умолчания "ленивой" загрузки, которая бы получила эти данные при 
                  первом обращении к ним, метод Include применяет "немедленную" загрузку, чтобы получить все эти данные сразу. 
                  Это полезно, если вы знаете, что вам понадобятся эти данные, и хотите избежать дополнительного обращения 
                  к базе данных немного позже.

                * .ThenInclude(v => v.ProductType) говорит EF не только получить данные о вариантах, но и связанные с вариантами 
                  данные о типах продуктов. Это еще одна немедленная загрузка.
            */
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == productId);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                    .Include(p => p.Variants)
                    .ToListAsync()
            };

            return response;
        }
    }
}
