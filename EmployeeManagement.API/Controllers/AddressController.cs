using EmployeeManagement.API.DTOs.Address;
using EmployeeManagement.API.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/Address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _db;
        public AddressController(IAddressRepository db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetAddresses()
        {
            var addresses = await _db.GetAddressesAsync();
            return Ok(addresses);
        }


        [HttpGet]
        [Route("Get/{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var address = await _db.GetAddressAsync(id);
            return Ok(address);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateAddress(AddressCreate addressCreate)
        {
            var id = await _db.CreateAddressAsync(addressCreate);
            return Ok(id);
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateAddress(AddressUpdate addressUpdate)
        {
            await _db.UpdateAddressAsync(addressUpdate);
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAddress(AddressDelete addressDelete)
        {
            await _db.DeleteAddressAsync(addressDelete);
            return Ok();
        }
    }
}
