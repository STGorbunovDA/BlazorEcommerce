﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        //dotnet ef migrations add CreateInitial - добавить миграцию
        //dotnet ef migrations remove - удалить миграцию
        //dotnet ef database update

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
               .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
               .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                   new ProductType { Id = 1, Name = "Default" },
                   new ProductType { Id = 2, Name = "Paperback" },
                   new ProductType { Id = 3, Name = "E-Book" },
                   new ProductType { Id = 4, Name = "Audiobook" },
                   new ProductType { Id = 5, Name = "Stream" },
                   new ProductType { Id = 6, Name = "Blu-ray" },
                   new ProductType { Id = 7, Name = "VHS" },
                   new ProductType { Id = 8, Name = "PC" },
                   new ProductType { Id = 9, Name = "PlayStation" },
                   new ProductType { Id = 10, Name = "Xbox" }
               );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       CategoryId = 1,
                       Title = "Слимп",
                       Description = "Семён, смышлёный парнишка 22 лет, сидя в компании приятелей, ненароком заскучал. Развернув одну из старых газет, он обнаружил странное объявление: к некоему Магическому Двору приглашались желающие получить профессию мага-воина. Не подумав, Семён механически прочитал вслух заклинание под объявлением (причём слова «Магический Двор» он спьяну прочитал как «Магический Вор») и оказался на… Вселенском Диске рядом с Магическим вором – живым, говорящим медальоном на цепочке…",
                       ImageUrl = "https://avidreaders.ru/pics/3/8/64838.jpg",
                       Featured = true,
                   },
                   new Product
                   {
                       Id = 2,
                       CategoryId = 1,
                       Title = "Слимпер",
                       Description = "Изумрудный Мир… Красивое название, не правда ли? А еще вот такие Миры: Тупиковый, Ханский, Мандариновый, Торговый, Выгребной… ну и Исправительный, как же без него? А еще Мир Равновесия, Мир Прокаженных и много всяких прочих. Все эти Истинные Миры располагаются на Вселенском Диске, по которому и скитается в поисках приключений или по необходимости удачливый вор Симеон, бывший «земной» студент, со своим странным другом – медальоном по имени Мар, обеспечивающим Симеону магическое прикрытие…",
                       ImageUrl = "https://avidreaders.ru/pics/0/3/433503.jpeg",
                   },
                   new Product
                   {
                       Id = 3,
                       CategoryId = 1,
                       Title = "Слиперия",
                       Description = "Пока Семён, вор с магическим прикрытием, искал достойный подарок ко дню коронации Яны, правительницы одного из самых крупных королевств Изумрудного Мира, та внезапно решила выйти замуж за его друга и телохранителя Хайка, воина из клана Болотной Черепахи. Это повергло Семёна в некоторую растерянность, перешедшую в двухнедельный загул. Хорошо, что у него есть Мар, магический медальон, который вытаскивает его из нехороших ситуаций, перебрасывая из одного Мира в другой. Но все когда-нибудь надоедает. Вот и Семён решает наконец отдохнуть и хорошенько подумать, что делать дальше. И тут он получает заказ от главы Вседисковой Гильдии Воров, Мастера Четырех Углов, выкрасть магический жезл – якобы для его личной коллекции. Так Семён знакомится с внучкой этого Мастера – Олией. К ним неожиданно присоединяется Хайк. Приключения продолжаются…",
                       ImageUrl = "https://avidreaders.ru/pics/0/0/166100.jpg",
                   },
                   new Product
                   {
                       Id = 4,
                       CategoryId = 2,
                       Title = "Матрица",
                       Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности",
                       ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/4774061/cf1970bc-3f08-4e0e-a095-2fb57c3aa7c6/300x450",
                       Featured = true,
                   },
                   new Product
                   {
                       Id = 5,
                       CategoryId = 2,
                       Title = "Назад в будущее",
                       Description = "Подросток Марти с помощью машины времени, сооружённой его другом-профессором доком Брауном, попадает из 80-х в далекие 50-е. Там он встречается со своими будущими родителями, ещё подростками, и другом-профессором, совсем молодым.",
                       ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1599028/73cf2ed0-fd52-47a2-9e26-74104360786a/300x450",
                   },
                   new Product
                   {
                       Id = 6,
                       CategoryId = 2,
                       Title = "История игрушек",
                       Description = "В спальне Энди его игрушки начинают жить своей жизнью, как только он выходит из комнаты. В день рождения мальчика царит паника — все боятся появления новой игрушки, которая перетянет внимание на себя. И только любимчик Эдди, ковбой Вуди, ни о чем не переживает. Однако, когда мальчик получает в подарок фигурку астронавта Базза Лайтера, Вуди очень быстро оказывается забыт. И тогда ковбой решает вернуть себе первое место в сердце Энди.",
                       ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1704946/46fd178b-9a99-4974-a7b5-4b56bbc4b08e/300x450",

                   },
                   new Product
                   {
                       Id = 7,
                       CategoryId = 3,
                       Title = "Half-Life 2",
                       Description = "Продолжение легендарного приключенческого шутера с видом от первого лица. Вам вновь предстоит поднять монтировку ученого-исследователя Гордона Фримена, который обнаруживает себя на наводненной чужаками Земле, ресурсы которой стремительно опустошаются, а население вырождается. Фримену навязана неизбежная роль спасителя человечества от того зла, которое он выпустил на свободу в Черной Мезе.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                       Featured = true,

                   },
                   new Product
                   {
                       Id = 8,
                       CategoryId = 3,
                       Title = "Diablo II",
                       Description = "Компьютерная игра в жанре Action/RPG, разработанная американской компанией Blizzard North и выпущенная Blizzard Entertainment для Windows и Mac OS в 2000 году. Это вторая часть серии Diablo, продолжающая события игры Diablo. В соответствии с сюжетом игры, выполненной в духе тёмного фэнтези, вымышленный мир Санктуарий подвергается нашествию демонов, которым противостоит управляемый игроком персонаж. Как и предыдущая игра серии, Diablo II содержит упрощенный по сравнению с компьютерными ролевыми играми, но увлекательный геймплей, предлагая игроку уничтожать толпы противников и вознаграждая его приростом характеристик и предметами экипировки для персонажа.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                   },
                   new Product
                   {
                       Id = 9,
                       CategoryId = 3,
                       Title = "Day of the Tentacle",
                       Description = "Графическая приключенческая игра 1993 года, разработанная и изданная LucasArts. Это продолжение вышедшей в 1987 году игры Maniac Mansion. Сюжет повествует о Бернарде Бернулли и его друзьях Хоги и Лаверне, которые пытаются остановить злое Фиолетовое Щупальце - разумное, бестелесное щупальце - от захвата мира.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                   },
                   new Product
                   {
                       Id = 10,
                       CategoryId = 3,
                       Title = "Xbox",
                       Description = "Домашняя игровая консоль, разработанная и выпущенная американской корпорацией Microsoft, первая в одноимённой серии игровых приставок Xbox. Выход Xbox в США и Канаде состоялся в ноябре 2001 года, в остальном мире - в 2002 году. ",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                       Featured = true,
                   },
                   new Product
                   {
                       Id = 11,
                       CategoryId = 3,
                       Title = "Super Nintendo Entertainment System",
                       Description = "16-битная игровая приставка, выпущенная компанией Nintendo в США, Бразилии, Европе и Австралии. В Японии она известна под названием Super Famicom (яп. スーパーファミコン су:па:фамикон), сокращение от Super Family Computer, или SFC. ",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                   }
                   );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 5,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 6,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 7,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 8,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 9,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 10,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 8,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 8,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 1,
                    Price = 159.99m,
                    OriginalPrice = 299m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 1,
                    Price = 79.99m,
                    OriginalPrice = 399m
                }
            );
        }
    }
}
