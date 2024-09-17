using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASPMVC_02.DAL.Entities
{
    public class PokemonType
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }

    }
}
