﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Семён, смышлёный парнишка 22 лет, сидя в компании приятелей, ненароком заскучал. Развернув одну из старых газет, он обнаружил странное объявление: к некоему Магическому Двору приглашались желающие получить профессию мага-воина. Не подумав, Семён механически прочитал вслух заклинание под объявлением (причём слова «Магический Двор» он спьяну прочитал как «Магический Вор») и оказался на… Вселенском Диске рядом с Магическим вором – живым, говорящим медальоном на цепочке…",
                            ImageUrl = "https://avidreaders.ru/pics/3/8/64838.jpg",
                            Price = 9.99m,
                            Title = "Слимп"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Изумрудный Мир… Красивое название, не правда ли? А еще вот такие Миры: Тупиковый, Ханский, Мандариновый, Торговый, Выгребной… ну и Исправительный, как же без него? А еще Мир Равновесия, Мир Прокаженных и много всяких прочих. Все эти Истинные Миры располагаются на Вселенском Диске, по которому и скитается в поисках приключений или по необходимости удачливый вор Симеон, бывший «земной» студент, со своим странным другом – медальоном по имени Мар, обеспечивающим Симеону магическое прикрытие…",
                            ImageUrl = "https://avidreaders.ru/pics/0/3/433503.jpeg",
                            Price = 7.99m,
                            Title = "Слимпер"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Пока Семён, вор с магическим прикрытием, искал достойный подарок ко дню коронации Яны, правительницы одного из самых крупных королевств Изумрудного Мира, та внезапно решила выйти замуж за его друга и телохранителя Хайка, воина из клана Болотной Черепахи. Это повергло Семёна в некоторую растерянность, перешедшую в двухнедельный загул. Хорошо, что у него есть Мар, магический медальон, который вытаскивает его из нехороших ситуаций, перебрасывая из одного Мира в другой. Но все когда-нибудь надоедает. Вот и Семён решает наконец отдохнуть и хорошенько подумать, что делать дальше. И тут он получает заказ от главы Вседисковой Гильдии Воров, Мастера Четырех Углов, выкрасть магический жезл – якобы для его личной коллекции. Так Семён знакомится с внучкой этого Мастера – Олией. К ним неожиданно присоединяется Хайк. Приключения продолжаются…",
                            ImageUrl = "https://avidreaders.ru/pics/0/0/166100.jpg",
                            Price = 6.99m,
                            Title = "Слиперия"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности",
                            ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/4774061/cf1970bc-3f08-4e0e-a095-2fb57c3aa7c6/300x450",
                            Price = 4.99m,
                            Title = "Матрица"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Подросток Марти с помощью машины времени, сооружённой его другом-профессором доком Брауном, попадает из 80-х в далекие 50-е. Там он встречается со своими будущими родителями, ещё подростками, и другом-профессором, совсем молодым.",
                            ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1599028/73cf2ed0-fd52-47a2-9e26-74104360786a/300x450",
                            Price = 3.99m,
                            Title = "Назад в будущее"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "В спальне Энди его игрушки начинают жить своей жизнью, как только он выходит из комнаты. В день рождения мальчика царит паника — все боятся появления новой игрушки, которая перетянет внимание на себя. И только любимчик Эдди, ковбой Вуди, ни о чем не переживает. Однако, когда мальчик получает в подарок фигурку астронавта Базза Лайтера, Вуди очень быстро оказывается забыт. И тогда ковбой решает вернуть себе первое место в сердце Энди.",
                            ImageUrl = "https://avatars.mds.yandex.net/get-kinopoisk-image/1704946/46fd178b-9a99-4974-a7b5-4b56bbc4b08e/300x450",
                            Price = 2.99m,
                            Title = "История игрушек"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Продолжение легендарного приключенческого шутера с видом от первого лица. Вам вновь предстоит поднять монтировку ученого-исследователя Гордона Фримена, который обнаруживает себя на наводненной чужаками Земле, ресурсы которой стремительно опустошаются, а население вырождается. Фримену навязана неизбежная роль спасителя человечества от того зла, которое он выпустил на свободу в Черной Мезе.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Price = 49.99m,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Компьютерная игра в жанре Action/RPG, разработанная американской компанией Blizzard North и выпущенная Blizzard Entertainment для Windows и Mac OS в 2000 году. Это вторая часть серии Diablo, продолжающая события игры Diablo. В соответствии с сюжетом игры, выполненной в духе тёмного фэнтези, вымышленный мир Санктуарий подвергается нашествию демонов, которым противостоит управляемый игроком персонаж. Как и предыдущая игра серии, Diablo II содержит упрощенный по сравнению с компьютерными ролевыми играми, но увлекательный геймплей, предлагая игроку уничтожать толпы противников и вознаграждая его приростом характеристик и предметами экипировки для персонажа.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Price = 9.99m,
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Графическая приключенческая игра 1993 года, разработанная и изданная LucasArts. Это продолжение вышедшей в 1987 году игры Maniac Mansion. Сюжет повествует о Бернарде Бернулли и его друзьях Хоги и Лаверне, которые пытаются остановить злое Фиолетовое Щупальце - разумное, бестелесное щупальце - от захвата мира.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Price = 14.99m,
                            Title = "Day of the Tentacle"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Домашняя игровая консоль, разработанная и выпущенная американской корпорацией Microsoft, первая в одноимённой серии игровых приставок Xbox. Выход Xbox в США и Канаде состоялся в ноябре 2001 года, в остальном мире - в 2002 году. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Price = 159.99m,
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "16-битная игровая приставка, выпущенная компанией Nintendo в США, Бразилии, Европе и Австралии. В Японии она известна под названием Super Famicom (яп. スーパーファミコン су:па:фамикон), сокращение от Super Family Computer, или SFC. ",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Price = 79.99m,
                            Title = "Super Nintendo Entertainment System"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
