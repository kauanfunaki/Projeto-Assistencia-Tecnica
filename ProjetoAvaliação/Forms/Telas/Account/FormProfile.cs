using ProjetoAvaliação.Classes.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliação.Forms.Telas.Account
{
    public partial class FormProfile : Form
    {
        public class Image_Profile
        {
            string connectionString = Database.GetConexao();
            public string PathProfile;
            public byte[] Image;

            public void GetImage(Image_Profile Image)
            {
                byte[] image = GetPath(Image.PathProfile);

                var query = "INSERT INTO clientes(picture_profile) values (@image)";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("image", System.Data.SqlDbType.Image, image.Length).Value = image;

                }
            }
            private byte[] GetPath(string Path)
            {
                byte[] imagemBytes;
                using (var stream = new FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        imagemBytes = reader.ReadBytes((int)stream.Length);
                    }
                }
                return imagemBytes;

            }
        }
        public FormProfile()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseCart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
