using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [StringLength(100)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }


        
    }
}
