using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliação.Classes.Database
{
    internal class DatabaseCarrinho
    {
        private string connectionString = Database.GetConexao();
        public bool Read(int produto_id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string produtoQuery = "SELECT id, nome, descricao, preco, URL_img FROM produtos WHERE id = @produto_id";
                SqlCommand command = new SqlCommand(produtoQuery, connection);
                command.Parameters.AddWithValue("@produto_id", produto_id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string nome = reader["nome"].ToString();
                    string descricao = reader["descricao"].ToString();
                    float preco = Convert.ToSingle(reader["preco"]);
                    int quantidade = Convert.ToInt32(reader["quantidade"]);


                    reader.Close();

                    int count = command.ExecuteNonQuery();

                    return count > 0;
                }
                else
                {
                    reader.Close();
                    return false;
                }

            }
            catch (Exception)
            {

            }

            return false;
        }

        public bool Update(string nome, int quantidade, float preco_total)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string sqlQuery = "UPDATE carrinho SET quantidade = @quantidade, preco_total = @preco_total WHERE nome = @nome;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@quantidade", quantidade);
                command.Parameters.AddWithValue("@preco_total", preco_total);
                command.Parameters.AddWithValue("@nome", nome);

                int rows = command.ExecuteNonQuery();

                connection.Close();
                return rows > 0;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public bool Delete(int produto_id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string sqlQuery = "DELETE FROM carrinho WHERE produto_id = @produto_id;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@produto_id", produto_id);

                int rows = command.ExecuteNonQuery();

                connection.Close();
                return rows > 0;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }
    }
}
