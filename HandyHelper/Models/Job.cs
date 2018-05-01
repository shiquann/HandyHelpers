using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandyHelper.Models
{
    public class Job
    {
        public int Id { get; set; }


        public string PostingTitle { get; set; }
        public string Discription { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RetryEmail { get; set; }
        public string City { get; set; }
        public State States { get; set; }
        public string Pictures { get; set; }
        public string Distance { get; set; }
        public string TypeOfJob { get; set; }
        public int Price { get; set; }
        public int PhoneNumber { get; set; }
        public int ZipCode { get; set; }
        public string ImageName { get; set; }




    }
}
