using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace loc_data.Migrations
{
    public partial class PopularUsuarioClienteFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuario(Login,Senha,Nome)" +
                "values('breno','123','Breno Moraes')");

            migrationBuilder.Sql("INSERT INTO Filme(Nome,Categoria)" +
                "values('Vingadores','Heroes')");
            migrationBuilder.Sql("INSERT INTO Cliente(Nome,Cpf)" +
                "values('Giovanna','12345678911')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Usuario");
            migrationBuilder.Sql("DELETE FROM Filme");
            migrationBuilder.Sql("DELETE FROM Cliente");
        }
    }
}
