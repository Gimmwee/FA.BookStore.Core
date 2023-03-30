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
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        public IList<Book> Books { get; set; }
    }
}
