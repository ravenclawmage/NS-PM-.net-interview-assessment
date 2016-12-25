using Interview.Web.DataAccess;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interview.Web.Models
{
    [NotMapped]
    public class ContactModel : Contact
    {
        [Display(Name = nameof(Gender))]
        public override Gender GenderId
        {
            get; set;
        }
    }
}