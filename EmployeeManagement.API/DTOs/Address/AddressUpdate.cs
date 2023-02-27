namespace EmployeeManagement.API.DTOs.Address
{
    public class AddressUpdate
    {
        public int Id { get; set; }
        public string Street { get; set; } = default!;
        public string Zip { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? Phone { get; set; }
    }
}
