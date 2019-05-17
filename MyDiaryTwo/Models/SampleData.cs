using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyDiaryOne.Models
{
    public class SampleData : DropCreateDatabaseAlways<DiaryDB>
    {

        protected override void Seed(DiaryDB context)
        {
            context.Users.Add(new User
            {
                UserName = "derek",
                Password = "derek",
                Diaries = new List<Diary>
                {
                    new Diary {Title="Title01",Content="Conten01",PubDate=DateTime.Now },
                    new Diary {Title="Title02",Content="Conten02",PubDate=DateTime.Now },
                    new Diary {Title="Title03",Content="Conten03",PubDate=DateTime.Now }
                }
            });

            context.Users.Add(new User
            {
                UserName = "terena",
                Password = "terena",
                Diaries = new List<Diary>
                {
                    new Diary {Title="Title04",Content="Conten04",PubDate=DateTime.Now },
                    new Diary {Title="Title05",Content="Conten05",PubDate=DateTime.Now },
                    new Diary {Title="Title06",Content="Conten06",PubDate=DateTime.Now }
                }
            });
            base.Seed(context);
        }
    }
}