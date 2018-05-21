using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsAssistant
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string DocumentTheme { get; set; }
        public virtual IEnumerable<Signature> Signatures { get; set; }
        [ForeignKey("DocumentCreator")]
        public int DocumentCreatorId { get; set; }
        public Person DocumentCreator { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
