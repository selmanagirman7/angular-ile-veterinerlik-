﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescriptionDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescriptionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescriptionRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutNameDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutNameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitleRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryDescRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryNameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Entity.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAdressDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAdressEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyAdressRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponayMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Massage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entity.Corporate", b =>
                {
                    b.Property<int>("CorporateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleRy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CorporateId");

                    b.ToTable("Corporates");
                });

            modelBuilder.Entity("Entity.Galery", b =>
                {
                    b.Property<int>("GaleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GaleryId");

                    b.ToTable("Galeries");
                });

            modelBuilder.Entity("Entity.HomeAbout", b =>
                {
                    b.Property<int>("HomeAboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature2Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc2Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomeAboutId");

                    b.ToTable("HomeAbouts");
                });

            modelBuilder.Entity("Entity.Human", b =>
                {
                    b.Property<int>("HumanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitleEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitleRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HumanId");

                    b.ToTable("Humen");
                });

            modelBuilder.Entity("Entity.Kvkk", b =>
                {
                    b.Property<int>("KvkkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KvkkId");

                    b.ToTable("Kvkks");
                });

            modelBuilder.Entity("Entity.OurService", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureDescRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("OurServices");
                });

            modelBuilder.Entity("Entity.Privacy", b =>
                {
                    b.Property<int>("PrivacyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentDu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrivacyId");

                    b.ToTable("Privacies");
                });

            modelBuilder.Entity("Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AngleBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxSizeEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DimensionsEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Metarial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetarialEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pieces")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescriptionDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescriptionEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescriptionRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNameDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductNameRe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatAngle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatAngleEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWeightEng")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entity.Referance", b =>
                {
                    b.Property<int>("ReferanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceNameDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceNameEng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferanceNameRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferanceId");

                    b.ToTable("Referances");
                });

            modelBuilder.Entity("Entity.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPath5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderText2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderTextDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderTextRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });
#pragma warning restore 612, 618
        }
    }
}
