using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aparel_List.Models
{
    public class Aparelhos
    {
        public int Id { get; set; }
        public string Linha { get; set; }
        public string Usuario { get; set; }
        public string Cargo { get; set; }
        public string Time { get; set; }
        public string Gerente { get; set; }
        public string Aparelho { get; set; }
        public string NS { get; set; }
        public string IMEI1 { get; set; }
        public string IMEI2 { get; set; }
        public string MacAddress { get; set; }
        public string TermoRecebimento { get; set; }
        public string Obs { get; set; }
    }
}