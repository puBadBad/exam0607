using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exam0607.Models
{
    [MetadataType(typeof(NewsMatadata))]
    public partial class News
    {
    }

    public partial class NewsMatadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位 標題 必須是最大長度為50的字串")]
        public string Title { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public string Content { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public System.DateTime PublishDate { get; set; }
    }
}