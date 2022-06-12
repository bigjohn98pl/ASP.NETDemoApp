using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [RegularExpression("^[A-ZŻÓŁĆĄĘ][a-zA-ZżółćąęśŻÓŁĆĄĘ]*$", ErrorMessage = "Only Polish alphabet  allowed!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        [RegularExpression("^[A-ZŻÓŁĆĄĘ][a-zA-ZżółćąęśŻÓŁĆĄĘ]*$", ErrorMessage = "Only Polish alphabet  allowed!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone is required!")]
        [Phone]
        [RegularExpression(@"^((\+48) )?(\d{3}) (\d{3}) (\d{3})", ErrorMessage = "the number is: \"xxx xxx xxx or +48 xxx xxx xxx\"")]
        public string PhoneNumber { get; set; }

        public student()
        {

        }
    }
}
