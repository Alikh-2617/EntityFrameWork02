using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class SeededManyToManyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "5bcb6dd3-ab87-4800-b027-628666104204");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "e0c28688-f4cb-4949-83fc-70fa54cf7bf6");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "edba7e92-0b2e-4355-865c-99ddb86303ac");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "58c93865-582b-445d-9395-572f41e89201");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "cb0322aa-a99c-47d7-93d8-dff5e0edf9d1");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "d8984e28-5631-4f60-bdb9-f1b5ed32170b");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "08de0cdf-11f3-4944-bb34-ddedb5c8267d");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "39c60245-1026-4029-b435-9bb83ef59b75");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "7cd221c6-cda6-4e1b-b001-953b6776fd85");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "2946a19e-a97e-468a-aece-07b028f4f1a3");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "69e9e4a6-90a7-4113-82a3-a896d4edf08a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "76e07371-5b7f-4747-bfc4-f9525fbf213e");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "78e76443-9115-45b3-b7e2-557ecc2fb08c");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "7534d275-5802-4814-a8c5-6d2802a4073c", "Åre", "123 45", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4876) },
                    { "a8624464-79e8-4f5f-a36b-7fda04a44c55", "Östersund", "123 88", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4912) },
                    { "cd3cc49b-bdbb-4b04-bb28-57a085d33b8e", "Järpen", "123 45", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4893) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "8e58668c-bbca-4ee4-8d3d-c892d509c669", "Danmark", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4961) },
                    { "bd1261a6-2d4a-4658-95f5-d4bc3544fbcd", "Norway", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4948) },
                    { "d31022fc-e7e1-4b68-a03e-cb0210433cd0", "Sweden", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4934) }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "445824e5-851c-44d6-a2c9-3abdd5a6c132", "Periska" },
                    { "a1802cc7-e32d-4827-8cc1-0f9d1eeba87b", "Svenska" },
                    { "c44099a7-de4a-49dc-9470-2df0af525582", "Swedish" },
                    { "e3245a09-a97d-467a-a4e8-f8d8627b458d", "Norske" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "2b2cbe24-2bba-42ae-9054-f8aeabe7c0e0", 23, "Ali03", "123546", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4853) },
                    { "375f8470-f18f-4f9f-b91c-aebfc266b104", 23, "Ali02", "123546", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4840) },
                    { "7f83808d-be3f-48ee-a1e9-a01777891a64", 32, "Ali", "123456", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(3790) },
                    { "dffd409f-7f53-4d6a-a0f5-5988a8fa70e5", 23, "Ali01", "123546", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4826) },
                    { "e259343a-7ee6-4aa7-a6c5-426a88df45e9", 32, "Ali", "123456", new DateTime(2022, 11, 24, 20, 52, 29, 729, DateTimeKind.Local).AddTicks(4801) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PersonId" },
                values: new object[] { "a1802cc7-e32d-4827-8cc1-0f9d1eeba87b", "7f83808d-be3f-48ee-a1e9-a01777891a64" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "7534d275-5802-4814-a8c5-6d2802a4073c");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "a8624464-79e8-4f5f-a36b-7fda04a44c55");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: "cd3cc49b-bdbb-4b04-bb28-57a085d33b8e");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "8e58668c-bbca-4ee4-8d3d-c892d509c669");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "bd1261a6-2d4a-4658-95f5-d4bc3544fbcd");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: "d31022fc-e7e1-4b68-a03e-cb0210433cd0");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "445824e5-851c-44d6-a2c9-3abdd5a6c132");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "c44099a7-de4a-49dc-9470-2df0af525582");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "e3245a09-a97d-467a-a4e8-f8d8627b458d");

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PersonId" },
                keyValues: new object[] { "a1802cc7-e32d-4827-8cc1-0f9d1eeba87b", "7f83808d-be3f-48ee-a1e9-a01777891a64" });

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "2b2cbe24-2bba-42ae-9054-f8aeabe7c0e0");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "375f8470-f18f-4f9f-b91c-aebfc266b104");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "dffd409f-7f53-4d6a-a0f5-5988a8fa70e5");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e259343a-7ee6-4aa7-a6c5-426a88df45e9");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: "a1802cc7-e32d-4827-8cc1-0f9d1eeba87b");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "7f83808d-be3f-48ee-a1e9-a01777891a64");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "5bcb6dd3-ab87-4800-b027-628666104204", "Åre", "123 45", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1360) },
                    { "e0c28688-f4cb-4949-83fc-70fa54cf7bf6", "Järpen", "123 45", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1378) },
                    { "edba7e92-0b2e-4355-865c-99ddb86303ac", "Östersund", "123 88", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1390) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "58c93865-582b-445d-9395-572f41e89201", "Norway", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1421) },
                    { "cb0322aa-a99c-47d7-93d8-dff5e0edf9d1", "Sweden", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1406) },
                    { "d8984e28-5631-4f60-bdb9-f1b5ed32170b", "Danmark", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1432) }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "08de0cdf-11f3-4944-bb34-ddedb5c8267d", "Svenska" },
                    { "39c60245-1026-4029-b435-9bb83ef59b75", "Norske" },
                    { "7cd221c6-cda6-4e1b-b001-953b6776fd85", "Periska" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "2946a19e-a97e-468a-aece-07b028f4f1a3", 23, "Ali03", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1318) },
                    { "69e9e4a6-90a7-4113-82a3-a896d4edf08a", 23, "Ali02", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1303) },
                    { "76e07371-5b7f-4747-bfc4-f9525fbf213e", 32, "Ali", "123456", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1223) },
                    { "78e76443-9115-45b3-b7e2-557ecc2fb08c", 23, "Ali01", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1289) }
                });
        }
    }
}
