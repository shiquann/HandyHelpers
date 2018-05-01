using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandyHelper.Models
{
    public class AddJobViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please add a posting title ")]
        public string PostingTitle { get; set; }

        [Required(ErrorMessage = "Please add a Discription")]
        public string Discription { get; set; }

        [Required(ErrorMessage = "Please enter a price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Please enter a state")]
        public State JobState { get; set; }

        public List<SelectListItem> JobStates { get; set; }
        
        [Required(ErrorMessage = "Please enter a zip")]
        public int ZipCode { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string ImageName { get; set; }

        public AddJobViewModel()
        {
     
            JobStates = new List<SelectListItem>();

            foreach (State states in Enum.GetValues(typeof(State)))
            {
                JobStates.Add(new SelectListItem
                {
                    Value = states.ToString(),
                    Text = states.ToString()
                    
                });
            }


        }
    }
}
