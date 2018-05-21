using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsAssistant
{
    public class Signature
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
        public string Sign { get; set; }
        public DateTime SignDate { get; set; }
    }
}
