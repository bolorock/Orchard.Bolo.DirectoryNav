using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;

namespace Bolo.DirectoryNav
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            SchemaBuilder.CreateTable("LinkPartRecord",
                table => table
                    .ContentPartRecord()
                    .Column<int>("TitleRecord_Id")
                    .Column<string>("Name",column=>column.WithLength(20))
                    .Column<string>("Url")
                    .Column<bool>("IsShow")
                    );

            SchemaBuilder.CreateTable("TitleRecord",
                table => table
                    .Column<int>("Id", column => column.PrimaryKey().Identity())
                    .Column<string>("Name",column=>column.WithLength(20))
                    );

            ContentDefinitionManager.AlterTypeDefinition("DiretoryNavWidget", cfg => cfg
               .WithPart("DirectoryNavPard")
               .WithPart("WidgetPart")
               .WithPart("CommonPart")

               .WithSetting("Stereotype", "Widget"));

            return 1;
        }
    }
}