using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Question
    {
        public long Id { get; set;  }
          
        public string Questionn { get; set; }
         
        public string Answer { get; set; }

        public int interview_id { get; set; }
    }
}
