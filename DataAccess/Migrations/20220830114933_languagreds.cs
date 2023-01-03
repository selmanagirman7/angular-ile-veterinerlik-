using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class languagreds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderText3",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderText4",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderText5",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "SliderTextDe",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderTextRu",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferanceNameDe",
                table: "Referances",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferanceNameRu",
                table: "Referances",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescriptionDe",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescriptionRu",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNameDe",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNameRe",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentDu",
                table: "Privacies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentRu",
                table: "Privacies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDe",
                table: "Privacies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleRu",
                table: "Privacies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescDe",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescRu",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureDe",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureDescDe",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureDescRu",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureRu",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDe",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleRu",
                table: "OurServices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentDe",
                table: "Kvkks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentRu",
                table: "Kvkks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDe",
                table: "Kvkks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleRu",
                table: "Kvkks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentDe",
                table: "Humen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentRe",
                table: "Humen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageTitleDe",
                table: "Humen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageTitleRu",
                table: "Humen",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescDe",
                table: "Corporates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescRu",
                table: "Corporates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleDe",
                table: "Corporates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleRy",
                table: "Corporates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyAdressDe",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyAdressRu",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyNameDe",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyNameRu",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescDe",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescRu",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameDe",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameRu",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutDescriptionDe",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutDescriptionRu",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutNameDe",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutNameRu",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutTitleDe",
                table: "Abouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutTitleRu",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderTextDe",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "SliderTextRu",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "ReferanceNameDe",
                table: "Referances");

            migrationBuilder.DropColumn(
                name: "ReferanceNameRu",
                table: "Referances");

            migrationBuilder.DropColumn(
                name: "ProductDescriptionDe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDescriptionRu",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductNameDe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductNameRe",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ContentDu",
                table: "Privacies");

            migrationBuilder.DropColumn(
                name: "ContentRu",
                table: "Privacies");

            migrationBuilder.DropColumn(
                name: "TitleDe",
                table: "Privacies");

            migrationBuilder.DropColumn(
                name: "TitleRu",
                table: "Privacies");

            migrationBuilder.DropColumn(
                name: "DescDe",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "DescRu",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "FeatureDe",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "FeatureDescDe",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "FeatureDescRu",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "FeatureRu",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "TitleDe",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "TitleRu",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "ContentDe",
                table: "Kvkks");

            migrationBuilder.DropColumn(
                name: "ContentRu",
                table: "Kvkks");

            migrationBuilder.DropColumn(
                name: "TitleDe",
                table: "Kvkks");

            migrationBuilder.DropColumn(
                name: "TitleRu",
                table: "Kvkks");

            migrationBuilder.DropColumn(
                name: "ContentDe",
                table: "Humen");

            migrationBuilder.DropColumn(
                name: "ContentRe",
                table: "Humen");

            migrationBuilder.DropColumn(
                name: "PageTitleDe",
                table: "Humen");

            migrationBuilder.DropColumn(
                name: "PageTitleRu",
                table: "Humen");

            migrationBuilder.DropColumn(
                name: "DescDe",
                table: "Corporates");

            migrationBuilder.DropColumn(
                name: "DescRu",
                table: "Corporates");

            migrationBuilder.DropColumn(
                name: "TitleDe",
                table: "Corporates");

            migrationBuilder.DropColumn(
                name: "TitleRy",
                table: "Corporates");

            migrationBuilder.DropColumn(
                name: "CompanyAdressDe",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CompanyAdressRu",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CompanyNameDe",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CompanyNameRu",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CategoryDescDe",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryDescRu",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryNameDe",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryNameRu",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AboutDescriptionDe",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutDescriptionRu",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutNameDe",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutNameRu",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutTitleDe",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutTitleRu",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "SliderText3",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderText4",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderText5",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
