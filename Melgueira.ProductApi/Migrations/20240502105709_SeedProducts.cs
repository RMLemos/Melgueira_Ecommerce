using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melgueira.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(ProductName, Description, Price, ImageURL, Stock, CreatedAt, CategoryId) " +
                          "Values('Honey','100% pure, natural, ethical and local honey.',7.00,'honey.jpg',10,NOW(),1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Products");
        }
    }
}
