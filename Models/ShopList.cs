using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marian_Cristina_Lab7.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
