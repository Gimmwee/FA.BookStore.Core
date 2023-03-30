using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    public class Publisher
    {
        [Key]
        public int PubId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
