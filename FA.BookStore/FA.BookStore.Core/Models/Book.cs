using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [ForeignKey("CateId")]
        public int CateId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("PubId")]
        public int PubId { get; set; }
        public Publisher Publisher { get; set; }

        [StringLength(50)]
        public string Summary { get; set; }
        public string ImgUrl { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool isActive { get; set; }

    }
}
