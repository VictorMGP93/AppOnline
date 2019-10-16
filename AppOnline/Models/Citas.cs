using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Sql;
using System.ComponentModel.DataAnnotations;

namespace AppOnline.Models
{
    public class Citas
    {
        [Key]
        public int ID { get; set; }

        public string Nombre{ get; set; }


    }
}
