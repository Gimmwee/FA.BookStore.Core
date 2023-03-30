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
        [StringLength(30)]
        public string Title { get; set; }

        [ForeignKey("Category")]
        public int CateId { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("Publisher")]
        public int PubId { get; set; }
        [StringLength(100)]
        public string Summary { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public IList<Comment> Comments { get; set; }

        public override string ToString()
        {
            return $"{BookId}\t{Title}\t{CateId}\t{AuthorId}\t{PubId}\t{Summary}\t{ImgUrl}\t{Price}\t{Quantity}\t{CreatedDate}\t{ModifiedDate}\t{IsActive}";
        }
    }
}

