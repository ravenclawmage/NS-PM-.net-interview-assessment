namespace Interview.Web.DataAccess
{
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        public int ContactId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public virtual Gender GenderId { get; set; }
    }

    public enum Gender
    {
        Female = 1,
        Male = 2,
        Other =3
    }
}
