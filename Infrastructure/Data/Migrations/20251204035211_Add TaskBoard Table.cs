using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskBoardTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BoardId",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "TaskBoards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskBoards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskBoards",
                column: "Id",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("03b31f58-aafe-7ac9-9c0e-2c50280dd5b8"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0536a50b-ce48-7563-95ab-8336e5c02382"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0be2285a-01b9-7677-b235-0ea0bb63181d"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0ce75541-8f68-7c96-971d-b0c18e251b21"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0fdaa886-4ee5-7d53-af70-cdfe5891247f"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("23f98e28-9302-7a62-a21f-4aba8049c1f3"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("25335252-e71d-7322-994d-dbc32d249c8e"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2ac037d8-ccff-7b2e-b9c4-f1c5c07aeccf"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2dbc57a4-dcb8-7e38-bcfa-4e538bce29df"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("2f6f5bb9-ff1f-7c0b-b48f-9cf3c6db158d"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("30712589-3cff-75a3-a667-ece13f7f7591"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3a539c4a-e5d7-75b8-a4a2-e4aaf08473fb"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3e0f06d4-bf71-72d2-9946-21ac609d4dd1"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("3fe0ab1c-9ac1-788a-aef3-f10270887a71"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("43b7e292-3584-7823-97e3-27caa21a4a6c"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("48cfb48f-89f8-702f-bb89-ba8344474646"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("4ad6e63e-4b4f-767d-a968-fea879cf4f59"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("542efcde-456a-7d7e-8fd0-e33dda521b1d"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("569bd1f4-c4e0-71c2-a17c-d0e535e0bc3d"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("58d64f63-5a5a-7ade-abab-8ef8eed4553f"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("59ec754f-ae62-73b7-8046-0fee8bddbf03"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("605e0ea5-41bc-72e5-820b-e32b45986db2"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("66297792-78b4-7f85-aa9b-9e7995827864"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6935ab0d-a9e5-70d9-8c27-0b475fda2568"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6bee3332-75d8-72c2-aafc-70ed06a8c33a"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("6facf3b9-8a1f-7c19-86c1-fc331b3dd9b0"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("770021b9-88ff-7319-8fea-927cccc31077"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("798d42c3-a760-780a-8173-686631e49843"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("80130472-2a00-7f46-98ae-4641f7e25fc7"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("88383c1a-c7b8-7965-8005-50eba4bad29f"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("892aa205-a8a7-7d25-a9b8-fc91b3464523"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("8c96900b-484d-7527-846d-74b522dbcf67"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("9d531d27-c06a-766e-8160-b8f178d5243f"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a0a57651-e11a-7834-a151-b86163fc1946"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a3511444-682a-7631-ab76-692e94ebbc8f"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("aabe2a3a-bd9e-7517-8e57-e99e4c53d130"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b2162483-224d-7404-be52-e0d9d83635c4"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b42132ed-c735-770c-ab7a-4b232e813039"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b7d15550-d1a2-7f5c-9b18-47949ccf8a09"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("bb18fbc1-7f10-792e-ac73-0b54c277ea8c"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("be2f849e-cfcc-7ebd-96f0-5c473813af0e"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c2e1c864-e71d-7043-bca5-97fcc8ff70a7"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c3ef5dce-258e-7823-8dbe-722f0a0f1ad7"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c9cc94f7-07ae-7270-b735-c232b106a62a"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ce6114fc-3dd4-7733-bab1-f3004eeb4230"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d03ffa08-1e13-703f-b610-945675990fc7"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d87fc77d-e061-7438-9994-def849e4654b"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f4e1c6b1-212e-7ca5-a132-4473c111d54c"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f61cbacc-0781-7fe4-a8d2-755e3d3f2e2e"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("fbb8b432-ee91-7d9b-920b-0014b236a164"),
                column: "BoardId",
                value: new Guid("4969a039-c082-44ad-a9a4-0efe2bba3de3"));

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskBoards_BoardId",
                table: "Tasks",
                column: "BoardId",
                principalTable: "TaskBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskBoards_BoardId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskBoards");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Tasks");
        }
    }
}
