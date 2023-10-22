using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности", "https://avatars.mds.yandex.net/get-kinopoisk-image/4774061/cf1970bc-3f08-4e0e-a095-2fb57c3aa7c6/300x450", 4.99m, "Матрица" },
                    { 5, 2, "Подросток Марти с помощью машины времени, сооружённой его другом-профессором доком Брауном, попадает из 80-х в далекие 50-е. Там он встречается со своими будущими родителями, ещё подростками, и другом-профессором, совсем молодым.", "https://avatars.mds.yandex.net/get-kinopoisk-image/1599028/73cf2ed0-fd52-47a2-9e26-74104360786a/300x450", 3.99m, "Назад в будущее" },
                    { 6, 2, "В спальне Энди его игрушки начинают жить своей жизнью, как только он выходит из комнаты. В день рождения мальчика царит паника — все боятся появления новой игрушки, которая перетянет внимание на себя. И только любимчик Эдди, ковбой Вуди, ни о чем не переживает. Однако, когда мальчик получает в подарок фигурку астронавта Базза Лайтера, Вуди очень быстро оказывается забыт. И тогда ковбой решает вернуть себе первое место в сердце Энди.", "https://avatars.mds.yandex.net/get-kinopoisk-image/1704946/46fd178b-9a99-4974-a7b5-4b56bbc4b08e/300x450", 2.99m, "История игрушек" },
                    { 7, 3, "Продолжение легендарного приключенческого шутера с видом от первого лица. Вам вновь предстоит поднять монтировку ученого-исследователя Гордона Фримена, который обнаруживает себя на наводненной чужаками Земле, ресурсы которой стремительно опустошаются, а население вырождается. Фримену навязана неизбежная роль спасителя человечества от того зла, которое он выпустил на свободу в Черной Мезе.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 49.99m, "Half-Life 2" },
                    { 8, 3, "Компьютерная игра в жанре Action/RPG, разработанная американской компанией Blizzard North и выпущенная Blizzard Entertainment для Windows и Mac OS в 2000 году. Это вторая часть серии Diablo, продолжающая события игры Diablo. В соответствии с сюжетом игры, выполненной в духе тёмного фэнтези, вымышленный мир Санктуарий подвергается нашествию демонов, которым противостоит управляемый игроком персонаж. Как и предыдущая игра серии, Diablo II содержит упрощенный по сравнению с компьютерными ролевыми играми, но увлекательный геймплей, предлагая игроку уничтожать толпы противников и вознаграждая его приростом характеристик и предметами экипировки для персонажа.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 9.99m, "Diablo II" },
                    { 9, 3, "Графическая приключенческая игра 1993 года, разработанная и изданная LucasArts. Это продолжение вышедшей в 1987 году игры Maniac Mansion. Сюжет повествует о Бернарде Бернулли и его друзьях Хоги и Лаверне, которые пытаются остановить злое Фиолетовое Щупальце - разумное, бестелесное щупальце - от захвата мира.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 14.99m, "Day of the Tentacle" },
                    { 10, 3, "Домашняя игровая консоль, разработанная и выпущенная американской корпорацией Microsoft, первая в одноимённой серии игровых приставок Xbox. Выход Xbox в США и Канаде состоялся в ноябре 2001 года, в остальном мире - в 2002 году. ", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 159.99m, "Xbox" },
                    { 11, 3, "16-битная игровая приставка, выпущенная компанией Nintendo в США, Бразилии, Европе и Австралии. В Японии она известна под названием Super Famicom (яп. スーパーファミコン су:па:фамикон), сокращение от Super Family Computer, или SFC. ", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 79.99m, "Super Nintendo Entertainment System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
