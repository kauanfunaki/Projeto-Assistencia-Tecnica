using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAvaliação.Classes.Getters_Setters
{
    internal class Carrinho
    {
        private int id {  get; set; }
        private int produto_id { get; set; }
        private int servico_id { get; set; }
        private int quantidade {  get; set; }
        private float preco_total { get; set; }
    }
}
