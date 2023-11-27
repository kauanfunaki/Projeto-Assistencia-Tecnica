using Microsoft.VisualBasic.ApplicationServices;
using ProjetoAvaliação.Classes.Design;
using ProjetoAvaliação.Classes.Getters_Setters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoAvaliação.Classes.Database
{
    internal class DatabaseClientes
    {
        private string connectionString = Database.GetConexao();

        public enum ErrorAuthentication
        {
            UsernameIncorreto,
            PasswordIncorreto,
            ErroDesconhecido,
            DadosValidos
        }

        public ErrorAuthentication Authentication(string usuario, string senha)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                string sqlQuery = "SELECT COUNT(*) FROM clientes  WHERE usuario = @usuario;";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@usuario", usuario);

                int countUsername = (int)command.ExecuteScalar();

                if (countUsername == 0)
                {
                    conn.Close();
                    return ErrorAuthentication.UsernameIncorreto;
                }
                else
                {
                    sqlQuery = "SELECT COUNT(*) FROM clientes WHERE usuario = @usuario AND senha = @senha;";
                    command = new SqlCommand(sqlQuery, conn);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@senha", senha);

                    int countSenha = (int)command.ExecuteScalar();

                    conn.Close();

                    if (countSenha == 0)
                    {
                        return ErrorAuthentication.PasswordIncorreto;
                    }

                    return ErrorAuthentication.DadosValidos;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return ErrorAuthentication.ErroDesconhecido;
            }
        }

        public int Authentication(string usuario, string senha, int aux)
        {
            int usuarioID = -1;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                string query = "SELECT id FROM clientes WHERE usuario = @usuario AND senha = @senha";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", senha);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    usuarioID = Convert.ToInt32(result);
                }
            }
            catch (Exception)
            {
                conn.Close();
            }

            return usuarioID;
        }

        public bool Create(string usuario, string password, string email)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string sqlQuery = "INSERT INTO clientes (usuario, senha, email) VALUES (@usuario, @senha, @email);";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@senha", password);
                command.Parameters.AddWithValue("@email", email);

                int count = command.ExecuteNonQuery();

                connection.Close();
                return count > 0;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }
        public DataTable Read(int? id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            if (id != null)
            {
                try
                {
                    string sqlQuery = $"SELECT * FROM clientes WHERE id = '{id}';";

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);

                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    conn.Close();
                    return data;
                }
                catch (Exception)
                {
                    conn.Close();
                    RJMessageBox.Show("Não foi possível carregar os dados.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }
            }
            else
            {
                try
                {
                    string sqlQuery = "SELECT * FROM clientes";

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);

                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    conn.Close();
                    return data;
                }
                catch (Exception)
                {
                    conn.Close();
                    RJMessageBox.Show("Não foi possível carregar os dados!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;
                }
            }
        }

        public List<string> SearchFill(int id)
        {
            List<string> listaValores = new List<string>();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sqlQuery = "SELECT * FROM clientes WHERE id = @id;";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                listaValores.Add(reader["usuario"].ToString());
                listaValores.Add(reader["nome_completo"].ToString());
                listaValores.Add(reader["email"].ToString());
                listaValores.Add(reader["cpf"].ToString());
                listaValores.Add(reader["cep"].ToString());
                listaValores.Add(reader["rua"].ToString());
                listaValores.Add(reader["numero"].ToString());
                listaValores.Add(reader["bairro"].ToString());
                listaValores.Add(reader["cidade"].ToString());
                listaValores.Add(reader["estado"].ToString());
                listaValores.Add(reader["pais"].ToString());

                connection.Close();
                return listaValores;
            }
            else
            {
                connection.Close();
                return null;
            }
        }


        public bool Update(int id_atual, string usuario, string nome, string cpf, string email,
            string telefone, string cep, string rua, int numero, string bairro, string cidade, string estado, string pais)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string enderecoQuery = "INSERT INTO enderecos (rua, numero, bairro, cidade, estado, pais, cep)" +
                    " VALUES (@rua, @numero, @bairro, @cidade, @estado, @pais, @cep);" +
                    " SELECT SCOPE_IDENTITY();";
                SqlCommand enderecoCommand = new SqlCommand(enderecoQuery, connection);

                enderecoCommand.Parameters.AddWithValue("@rua", rua);
                enderecoCommand.Parameters.AddWithValue("@numero", numero);
                enderecoCommand.Parameters.AddWithValue("@bairro", bairro);
                enderecoCommand.Parameters.AddWithValue("@cidade", cidade);
                enderecoCommand.Parameters.AddWithValue("@estado", estado);
                enderecoCommand.Parameters.AddWithValue("@pais", pais);
                enderecoCommand.Parameters.AddWithValue("@cep", cep);

                int endereco_id = Convert.ToInt32(enderecoCommand.ExecuteScalar());

                string clienteQuery = "UPDATE clientes SET usuario = @usuario, nome_completo = @nome," +
                    " cpf = @cpf, email = @email, telefone = @telefone, endereco_id = @endereco_id" +
                    " WHERE id = @id_atual;";
                SqlCommand clienteCommand = new SqlCommand(clienteQuery, connection);

                clienteCommand.Parameters.AddWithValue("@usuario", usuario);
                clienteCommand.Parameters.AddWithValue("@nome", nome);
                clienteCommand.Parameters.AddWithValue("@cpf", cpf);
                clienteCommand.Parameters.AddWithValue("@email", email);
                clienteCommand.Parameters.AddWithValue("@telefone", telefone);
                clienteCommand.Parameters.AddWithValue("@endereco_id", endereco_id);

                clienteCommand.Parameters.AddWithValue("@id_atual", id_atual);

                int rows = clienteCommand.ExecuteNonQuery();

                connection.Close();
                return rows > 0;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public bool Delete(string cpf)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            try
            {
                string sqlQuery = "DELETE FROM Cadastros WHERE email = @email;";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@email", cpf);

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

        public string GetID(int id)
        {
            string usuario = "";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sqlQuery = $"SELECT usuario FROM clientes WHERE id = {id};";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = reader["usuario"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Não foi possível carregar os dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return usuario;
        }

        public Cliente GetClienteByID(int id)
        {
            Cliente cliente = new Cliente();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sqlQuery = @"
                    SELECT c.id, c.usuario, c.senha, c.email, c.nome_completo, c.telefone, c.cpf,
                           e.rua, e.numero, e.bairro, e.cidade, e.estado, e.pais, e.cep
                    FROM clientes c
                    JOIN enderecos e ON c.endereco_id = e.id
                    WHERE c.id = @id;
                ";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente.id = reader.GetInt32(reader.GetOrdinal("id"));
                    cliente.usuario = reader["usuario"].ToString();
                    cliente.senha = reader["senha"].ToString();
                    cliente.email = reader["email"].ToString();
                    cliente.nome_completo = reader["nome_completo"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    cliente.cpf = reader["cpf"].ToString();

                    cliente.rua = reader["rua"].ToString();
                    cliente.numero = reader.GetInt32(reader.GetOrdinal("numero"));
                    cliente.bairro = reader["bairro"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.pais = reader["pais"].ToString();
                    cliente.cep = reader["cep"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                RJMessageBox.Show($"Não foi possível carregar os dados: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return cliente;
        }
    }
}
