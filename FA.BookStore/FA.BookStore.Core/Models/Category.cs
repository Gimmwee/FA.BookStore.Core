using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    public class Category
    {
        [Key]
        public int CateId { get; set; }

        [Required]
        [StringLength(50)]
        public string CateName { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }
        public ICollection<Book> books { get; set; }

    }
}
