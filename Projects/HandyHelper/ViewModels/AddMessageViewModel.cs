using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandyHelper.ViewModels
{
    public class AddMessageViewModel
    {
        public int MessageId { get; set;}
        public string Title { get; set; }
        public string Messages { get; set; }
    }
}
