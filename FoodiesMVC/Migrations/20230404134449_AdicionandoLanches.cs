using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodiesMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset, TempoDePreparo)" +
               "VALUES('Drink Blackberry', 'Drink alcoólico (Vodka ou Gin) feito com blackberries frescas', 19.99 , 1, 0, 6,'../images/img/cauliflower-vegan.jpg', 20)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
                "VALUES('Suco de Laranja', 'Suco da fruta laranja natural, com toques cítricos e doces', 7.50, 1, 0, 6,'../images/img/suco-laranja.jpg', 10)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
                "VALUES('Suco de Morango', 'Suco de morango fresco com frutas selecionadas', 9.99, 1, 0, 6,'../images/img/suco-morango.jpg', 15)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
                "VALUES('Suco de Kiwi', 'Suco de kiwi fresco com frutas selecionadas', 9.99, 1, 0, 6,'../images/img/suco-kiwi.jpg', 12)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
                "VALUES('Limonada', 'Limonada especial da casa bem gelado', 9.99, 1, 0, 6,'../images/img/limonada.jpg', 12)");


            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
                "VALUES('Taco de Couve-Flor', 'Tacos veganos especiais de couve-flor gratinado na chapa', 25.99, 1, 0, 1,'../images/img/cauliflower-vegan.jpg', 10)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Sanduíche Natural', 'Sanduíche da casa com alface, tomate, cenoura e repolho refogado', 6.99, 1, 0, 1,'../images/img/img-3.jpg', 13)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Tortilha', 'Tortilha recheada com cenoura e frango grelhado', 12.99, 1, 0, 1,'../images/img/img-4.jpg', 40)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Salada de Ricota', 'Salada temperada com queijo ricota feito pela casa', 15.50, 1, 0, 1,'../images/img/salada-queijo.jpg', 15)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Ratatouille', 'O prato mais desejado da casa! O Ratatouille é um prato francês que causa diversas sensações pois é feito sempre pelo chefe da casa',45.99, 1, 0, 1,'../images/img/ratatouille.jpg', 50)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Salada de legumes', 'Salada com deliciosos e grelhados bróclis, cenouras, laranja, pepino e frango', 25.99, 1, 0, 1,'../images/img/vegetais-frango.png', 60)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
               "VALUES('Panqueca de Morango e Nutella', 'Panqueca de chocolate recheada com morangos e nutella', 19.99, 1, 0, 2,'../images/img/panqueca-morango.jpg', 20)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
              "VALUES('Milkshake de Oreo', 'Delicioso milkshake de oreo', 19.99, 1, 0, 2,'../images/img/milkshake-oreo.jpg',10)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
              "VALUES('Torta de Morango', 'Torta de morango com creme de baunilha', 19.99, 1, 0, 2,'../images/img/img-5.jpg', 30)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
              "VALUES('Geleia de Morango', 'Pote de geleia de morango com creme de frutas vermelhas', 12.99, 1, 0, 2,'../images/img/geleia-morango.jpg', 15)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
              "VALUES('Brownie de Nutella', 'Brownie de cacau com recheio de nutella', 14.50, 1, 0, 2,'../images/img/brownie.jpg', 25)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
              "VALUES('Bolinhos de Oreo', 'Bolinhos deliciosos recheados com um especial creme de oreo', 17.50, 1, 0, 2,'../images/img/bolinhos-oreo.jpg', 23)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Bolinhos de Oreo', 'Bolinhos deliciosos recheados com um especial creme de oreo', 17.50, 1, 0, 2,'../images/img/bolinhos-oreo.jpg', 17)");


            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Massa Alfredo', 'Massa italiana ao molho alfredo', 37.50, 1, 0, 3,'../images/img/massa-alfredo', 35)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Massa Camarão', 'Massa italiana ao molho cremoso com porções de camarão', 52.50, 1, 0, 3,'../images/img/massa-camarao', 30)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Massa de Espinafre', 'Massa de espinafre com toques cítricos e suaves', 47.50, 1, 0, 3,'../images/img/massa-espinafre', 32)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Massa Italiana', 'Massa italiana tradicional ao molho bolonhesa', 32.90, 1, 0, 3,'../images/img/massa-italiana', 40)");

            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Porção de Frango com Batatas', 'Frango frito com batatas suculentas e pepitos', 33.50, 1, 0, 4,'../images/img/frango-frito.jpg', 32)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Cheeseburguer', 'Cheeseburguer com cebolas fritas, blend de carne de 180g, queijo mussarela, alface tomate e pão batata', 19.50, 1, 0, 4,'../images/img/cheeseburguer.jpg', 28)");
            migrationBuilder.Sql("INSERT INTO Lanches (Nome, Descricao, Preco, Estoque, IsFavorite, CategoriaId, ImageAsset,TempoDePreparo)" +
             "VALUES('Combo Hamburguer MAX', 'Combo! Hamburguer com blend de 180g, alface tomate, molho da casa e cebola + porção de batata frita + refrigerante gelado', 30.50, 1, 0, 4,'../images/img/combo-hamburguer.jpg', 40)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
