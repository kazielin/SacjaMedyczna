using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacjaMedyczna.Model
{
    public class DaneOsobowe
    {
        [Key]
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }
        public string NumerDowodu { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public long NumerTelefonu { get; set; }
        public string Name { get; set; }
    }
}
