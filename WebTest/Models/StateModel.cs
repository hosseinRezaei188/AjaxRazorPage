using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class StateModel
    {
        [Required(ErrorMessage ="Please Select an item")]
        public int ID { get; set; }

        public SelectList states { get; set; }
    }
}
