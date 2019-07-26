using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astra.Model
{
    [Table("x_Planning")]
    public class x_Planning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public Nullable<long> p_senin { get; set; }
        public Nullable<long> p_selasa { get; set; }
        public Nullable<long> p_rabu { get; set; }
        public Nullable<long> p_kamis { get; set; }
        public Nullable<long> p_jumat { get; set; }
        public Nullable<long> p_sabtu { get; set; }
        public Nullable<long> p_minggu { get; set; }

        public Nullable<long> e_senin { get; set; }
        public Nullable<long> e_selasa { get; set; }
        public Nullable<long> e_rabu { get; set; }
        public Nullable<long> e_kamis { get; set; }
        public Nullable<long> e_jumat { get; set; }
        public Nullable<long> e_sabtu { get; set; }
        public Nullable<long> e_minggu { get; set; }

    }
}
