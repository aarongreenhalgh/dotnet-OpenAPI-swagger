using System.ComponentModel.DataAnnotations;

namespace dotnet.RESTful.OpenAPI.Endpoints.Login
{
    public class Login
    {
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
