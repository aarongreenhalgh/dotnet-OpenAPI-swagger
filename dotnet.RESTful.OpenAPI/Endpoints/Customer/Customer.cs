using System.ComponentModel.DataAnnotations;

namespace dotnet.RESTful.OpenAPI.Endpoints.Customer
{
    public class Customer
    {
        /// <summary>
        /// The customers Id generated
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Id { get; set; }

        /// <summary>
        /// The customers forename
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Forename { get; set; }

        /// <summary>
        /// The customers surname
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Surname { get; set; }

        /// <summary>
        /// The customers date of birth
        /// </summary>
        [Required]
        public DateTime DOB { get; set; }

        /// <summary>
        /// The customers address
        /// </summary>
        [Required]
        public Address Address { get; set; }
    }

    public class Address
    {
        /// <summary>
        /// The customers address house, buidling or flat number
        /// </summary>
        [Required]
        public int HouseNumber { get; set; }

        /// <summary>
        /// The customers first line of address
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The customers second line of address
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The customers third line of address
        /// </summary>
        [MaxLength(255)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The customers fourth line of address
        /// </summary>
        [MaxLength(255)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// The customers address postcode
        /// </summary>
        [Required]
        [RegularExpression(@"^(GIR 0AA)|[a-z-[qvx]](?:\d|\d{2}|[a-z-[qvx]]\d|[a-z-[qvx]]\d[a-z-[qvx]]|[a-z-[qvx]]\d{2})(?:\s?\d[a-z-[qvx]]{2})?$")]
        public string Postcode { get; set; }

        /// <summary>
        /// The customers address county
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string County { get; set; }

        /// <summary>
        /// The customers address city
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Country { get; set; }
    }
}
