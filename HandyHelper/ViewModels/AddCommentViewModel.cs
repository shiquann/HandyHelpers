using HandyHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HandyHelper.ViewModels
{
    public class AddCommentViewModel
    {
        public int CommentId { get; set; }
        public string Comments { get; set; }
        public DateTime DateTime { get; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
