using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliação.Classes.Database
{
    internal class DatabaseProdutos
    {
        private string connectionString = Database.GetConexao();

        public bool Create(int produto_id, int usuario_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string produtoQuery = "SELECT id, nome, descricao, preco FROM produtos WHERE id = @produto_id AND situacao = 'ativo'";
                SqlCommand command = new SqlCommand(produtoQuery, conn);
                command.Parameters.AddWithValue("@produto_id", produto_id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string nome = reader["nome"].ToString();
                    string descricao = reader["descricao"].ToString();
                    float preco = Convert.ToSingle(reader["preco"]);

                    reader.Close();

                    string vendaQuery = "INSERT INTO carrinho (produto_id, cliente_id, quantidade, preco_total) VALUES (@produto_id, @cliente_id, 1, @preco_total);";
                    SqlCommand vendaCommand = new SqlCommand(vendaQuery, conn);
                    vendaCommand.Parameters.AddWithValue("@produto_id", id);
                    vendaCommand.Parameters.AddWithValue("@cliente_id", usuario_id);
                    vendaCommand.Parameters.AddWithValue("@preco_total", preco);

                    int count = vendaCommand.ExecuteNonQuery();

                    return count > 0;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
