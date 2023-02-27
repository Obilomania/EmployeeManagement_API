using AutoMapper;
using EmployeeManagement.API.DTOs.Address;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.IRepository.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Address> _addressRepository;

        public AddressRepository(IMapper mapper, IGenericRepository<Address> addressRepository)
        {
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<int> CreateAddressAsync(AddressCreate addressCreate)
        {
            var entity = _mapper.Map<Address>(addressCreate);
            await _addressRepository.InsertAsync(entity);
            await _addressRepository.SaveChangesAsync();
            return entity.Id;
        }

        public async Task DeleteAddressAsync(AddressDelete addressDelete)
        {
            var entity = await _addressRepository.GetByIdAsync(addressDelete.Id);
            _addressRepository.Delete(entity);
            await _addressRepository.SaveChangesAsync();
        }

        public async Task<AddressGet> GetAddressAsync(int id)
        {
            var entity = await _addressRepository.GetByIdAsync(id);
            return _mapper.Map<AddressGet>(entity);
        }

        public async Task<List<AddressGet>> GetAddressesAsync()
        {
            var entities = await _addressRepository.GetAsync(null, null);
            return _mapper.Map<List<AddressGet>>(entities);
        }

        public async Task UpdateAddressAsync(AddressUpdate addressUpdate)
        {
            //var existingEntity = await _addressRepository.GetByIdAsync(addressUpdate.Id);
            var entity = _mapper.Map<Address>(addressUpdate);
            _addressRepository.Update(entity);
            await _addressRepository.SaveChangesAsync();
        }
    }
}
