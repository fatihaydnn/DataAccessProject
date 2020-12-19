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
    public class Order : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime RequiredDate { get; set; }

        [Required]
        public DateTime ShippedDate { get; set; }

        [Required]
        public string ShipVia { get; set; }

        [Required]
        public string Freight { get; set; }

        [Required]
        public string ShipName { get; set; }

        [Required]
        public string ShipAdress { get; set; }

        [Required]
        public string ShipCity { get; set; }

        [Required]
        public string ShipRegion { get; set; }

        [Required]
        public int ShipPostalCode { get; set; }

        [Required]
        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Shipper Shipper { get; set; }

    }
}
