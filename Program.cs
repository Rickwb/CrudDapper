using CrudDapper.NewFolder;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace CrudDapper
{
    class Program
    {
        private const string stringConnection = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private async Task<bool> InsertAnimal(Animal animal)
        {
            await using var conn = new SqlConnection(stringConnection);

            var sql = "@INSERT INTO ANIMAL (id,name,race,family,age,IsDomestic)" +
                "VALUES (@IdAnimal,@Name,@Race,@Family,@Age,@Domestic);";
            var result = await conn.ExecuteAsync(sql, animal);

            if (result == 1)
                return true;

            return false;
        }
        private async Task<bool> UpdateAnimal(Animal animal)
        {
            await using var conn = new SqlConnection(stringConnection);

            var sql = "@UPDATE ANIMAL SET (name=@Name,race=@Race,family=@Family,age=@Age,IsDomestic=@Domestic)" +
                "WHERE id=@IdAnimal;";
            var result = await conn.ExecuteAsync(sql, animal);

            if (result == 1)
                return true;

            return false;
        }

        private async Task<bool> DeleteAnimal(Animal animal)
        {
            await using var conn = new SqlConnection(stringConnection);

            var sql = "@DELETE FROM ANIMAL WHERE id=@IdAnimal; ";

            var result = await conn.ExecuteAsync(sql, animal.Id);

            if (result == 1)
                return true;

            return false;
        }

    }
}
