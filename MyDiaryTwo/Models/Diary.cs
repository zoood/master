using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDiaryOne.Models
{
    public class Diary
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("Title"), Required]
        public string Title { get; set; }
        [DisplayName("Content"), Required]
        public string Content { get; set; }
        [DisplayName("PubDate"), DataType(DataType.Date)]
        public DateTime? PubDate { get; set; }

        [DisplayName("UserId")]
        public int UserId { get; set; }

        [DisplayName("User")]
        public virtual User User { get; set; }
    }
}