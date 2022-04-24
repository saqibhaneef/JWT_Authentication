using System.ComponentModel.DataAnnotations;

namespace JWT_Authentication.ViewModels
{
    public class Response
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }
}
