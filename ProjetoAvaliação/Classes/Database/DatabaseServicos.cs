using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliação.Classes.Database
{
    internal class DatabaseServicos
    {
        private string connectionString = Database.GetConexao();

        public bool Create(int servico_id, int usuario_id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string produtoQuery = "SELECT id, nome, preco FROM produtos WHERE id = @servico_id AND situacao = 'ativo'";
                SqlCommand command = new SqlCommand(produtoQuery, conn);
                command.Parameters.AddWithValue("@servico_id", servico_id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string nome = reader["nome"].ToString();
                    float preco = Convert.ToSingle(reader["preco"]);

                    reader.Close();

                    string vendaQuery = "INSERT INTO vendas (servico_id, cliente_id, quantidade, preco_total) VALUES (@servico_id, @cliente_id, 1, @preco_total);";
                    SqlCommand vendaCommand = new SqlCommand(vendaQuery, conn);

                    vendaCommand.Parameters.AddWithValue("@servico_id", id);
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
