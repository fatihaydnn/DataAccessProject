using DataAccessProjects.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessHomework.Entities.Concrete
{
    public class Shipper : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public int ShipperId { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public int Phone { get; set; }
    }
}
