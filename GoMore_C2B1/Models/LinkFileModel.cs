using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoMore_C2B1.Models
{
    [Table("LinkFileModel",Schema="public")]
    public class LinkFileModel
    {
        [Key]
        public string ID { get; set; }
        public string UnitFileName { get; set; }
        public string MainModel { get; set; }
        public string Url { get; set; }
        public string FileType { get; set; }
        public string Tag { get; set; }

    }
}