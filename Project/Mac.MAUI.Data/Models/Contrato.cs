using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac.MAUI.Data.Models
{
    public class Contrato
    {
        public Contrato(int id_Contrato, string nm_Empreendimento, string nm_Bloco, string nm_Unidade, string nm_Contrato, DateTime dt_DataVenda, bool fl_Ativo)
        {
            Id_Contrato = id_Contrato;
            Nm_Empreendimento = nm_Empreendimento;
            Nm_Bloco = nm_Bloco;
            Nm_Unidade = nm_Unidade;
            Nm_Contrato = nm_Contrato;
            Dt_DataVenda = dt_DataVenda;
            Fl_Ativo = fl_Ativo;
        }

        [Key]
        public int Id_Contrato { get; set; }
        public string Nm_Empreendimento { get; set; }
        public string Nm_Bloco { get; set; }
        public string Nm_Unidade { get; set; }
        public string Nm_Contrato { get; set; }
        public DateTime Dt_DataVenda { get; set; }
        public bool Fl_Ativo { get; set; }
    }
}
