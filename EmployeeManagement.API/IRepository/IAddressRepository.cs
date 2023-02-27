using EmployeeManagement.API.DTOs.Address;

namespace EmployeeManagement.API.IRepository
{
    public interface IAddressRepository
    {
        Task<int> CreateAddressAsync(AddressCreate addressCreate);
        Task UpdateAddressAsync(AddressUpdate addressUpdate);
        Task DeleteAddressAsync(AddressDelete addressDelete);
        Task<AddressGet> GetAddressAsync(int id);
        Task<List<AddressGet>> GetAddressesAsync();
    }
}
