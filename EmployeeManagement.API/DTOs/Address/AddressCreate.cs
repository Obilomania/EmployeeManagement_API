using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.DTOs.Address
{
    public class AddressCreate
    {
        public string Street { get; set; } = default!;
        public string Zip { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? Phone { get; set; }
    }
}
