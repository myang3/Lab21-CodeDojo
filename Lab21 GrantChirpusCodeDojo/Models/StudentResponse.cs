using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21_GrantChirpusCodeDojo.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select your gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        //(ReularExpression is a special pattern . = at least one, + =none or many more)
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify your course selection")]
        public bool? WillAttend { get; set; }
        //bool? takes 3 arguement (true,false,null)

        public bool WebsiteSearch { get; set; }
        public bool Newspaper { get; set; }
        public bool Radio { get; set; }
        public bool FriendsFamily { get; set; }
        public bool SocialMedia { get; set; }
        public bool Other { get; set; }


    }
}