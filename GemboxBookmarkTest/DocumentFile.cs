using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemboxBookmarkTest
{
    public partial class DocumentFile
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FileName { get; set; }

        [Required]
        public byte[] FileData { get; set; }

        [Timestamp]  // Indicates that this property should be treated as a concurrency token
        public byte[] RowVersion { get; set; }
    }
}
