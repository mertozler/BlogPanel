using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Mert"
                },
                new UserComment
                {
                    ID=2,
                    Username="Berat"
                },new UserComment
                {
                    ID=3,
                    Username="Kağan"
                }
            };
            return View(commentValues);
        }
    }
}
