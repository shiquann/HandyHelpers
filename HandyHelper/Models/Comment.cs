using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandyHelper.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Job Job { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
    }
}
