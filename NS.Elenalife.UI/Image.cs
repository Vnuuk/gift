using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NS.Elenalife.UI
{
    [Table("Image")]
    public class Image
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Path { get; set; }

        [ForeignKey("Id")]
        public virtual Post Post { get; set; }
    }
}