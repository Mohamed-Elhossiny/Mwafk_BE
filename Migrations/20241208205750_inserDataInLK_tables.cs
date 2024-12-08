using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mwafk_BE.Migrations
{
    /// <inheritdoc />
    public partial class inserDataInLK_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Cities] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'جدة', 'Jada', 0);");

            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Cities] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'دمام', 'Damam', 0);");

            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Cities] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'مكة', 'Meca', 0);");

            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Cities] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'الرياض', 'al-Riyadh', 0);");

            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Genders] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'ذكر', 'Male', 0);");

            migrationBuilder.Sql($@"INSERT INTO [dbo].[LK_Genders] ([NameAr], [NameEn], [IsDeleted])
					VALUES 
						(N'أنثي', 'Female', 0);");


            migrationBuilder.Sql($@"
        INSERT INTO [dbo].[LK_Nationalities] ([NameAr], [NameEn], [IsDeleted])
        VALUES 
            (N'مصرى', 'Egyptian', 0),
            (N'سعودى', 'Saudi', 0),
            (N'إماراتى', 'Emirati', 0),
            (N'كويتى', 'Kuwaiti', 0),
            (N'بحرينى', 'Bahraini', 0),
            (N'قطرى', 'Qatari', 0),
            (N'عمانى', 'Omani', 0),
            (N'اردنى', 'Jordanian', 0),
            (N'لبنانى', 'Lebanese', 0),
            (N'سورى', 'Syrian', 0),
            (N'عراقى', 'Iraqi', 0),
            (N'ليبى', 'Libyan', 0),
            (N'تونسى', 'Tunisian', 0),
            (N'جزائرى', 'Algerian', 0),
            (N'مغربى', 'Moroccan', 0),
            (N'سودانى', 'Sudanese', 0),
            (N'يمنى', 'Yemeni', 0),
            (N'فلسطينى', 'Palestinian', 0),
            (N'صومالى', 'Somali', 0),
            (N'جيبوتى', 'Djiboutian', 0);
    ");

			migrationBuilder.Sql($@"
                INSERT INTO [dbo].[LK_Areas] ([Lat], [Long], [CityId], [NameAr], [NameEn], [IsDeleted])
                VALUES
                    (21.543333, 39.172778, (SELECT Id FROM [dbo].[LK_Cities] WHERE [NameEn] = 'Jeddah'), N'منطقة جدة', 'Jeddah Area', 0),
                    (24.713552, 46.675297, (SELECT Id FROM [dbo].[LK_Cities] WHERE [NameEn] = 'Riyadh'), N'منطقة الرياض', 'Riyadh Area', 0),
                    (26.420681, 50.088794, (SELECT Id FROM [dbo].[LK_Cities] WHERE [NameEn] = 'Dammam'), N'منطقة الدمام', 'Dammam Area', 0),
                    (21.485811, 39.192505, (SELECT Id FROM [dbo].[LK_Cities] WHERE [NameEn] = 'Mecca'), N'منطقة مكة', 'Mecca Area', 0);
            ");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
