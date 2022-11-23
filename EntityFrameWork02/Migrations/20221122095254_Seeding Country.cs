using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class SeedingCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "264c11c4-86aa-46c5-9c13-fede88b2420f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "6cfee36d-bdf1-46df-9184-913b925d1c70");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e22e1ae9-e8dd-401f-8793-af4c6b03f7d8");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e4d7943c-8975-4ca6-9a1f-25c2e5c54dcc");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Name", "Register" },
                values: new object[,]
                {
                    { "Danmark", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4068) },
                    { "Norway", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4024) },
                    { "Sweden", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4013) }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "43f1abec-60b3-4ac0-b098-8f477c528b93", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3888) },
                    { "db6c953f-5806-4c04-a525-dbc8e74331e1", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3970) },
                    { "dc0771c6-9216-466c-8f77-2d888a51b9fa", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3947) },
                    { "fdb1103d-f232-44cd-81d6-29809bab5b45", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3959) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "43f1abec-60b3-4ac0-b098-8f477c528b93");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "db6c953f-5806-4c04-a525-dbc8e74331e1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "dc0771c6-9216-466c-8f77-2d888a51b9fa");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "fdb1103d-f232-44cd-81d6-29809bab5b45");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "264c11c4-86aa-46c5-9c13-fede88b2420f", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8012) },
                    { "6cfee36d-bdf1-46df-9184-913b925d1c70", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(7952) },
                    { "e22e1ae9-e8dd-401f-8793-af4c6b03f7d8", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8025) },
                    { "e4d7943c-8975-4ca6-9a1f-25c2e5c54dcc", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8038) }
                });
        }
    }
}
