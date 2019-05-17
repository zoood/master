using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyDiaryOne.Models
{
    public class User
    {
        [DisplayName("Id")]
        public int Id { get; set; }
        [DisplayName("UserName"), Required]
        public string UserName { get; set; }
        [DisplayName("Password"), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Diaries")]
        public virtual List<Diary> Diaries { get; set; }
    }
}