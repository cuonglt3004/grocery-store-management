using AutoMapper;
using Contracts;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grocery_Store_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        public CustomerController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            try
            {
                var customers = _repository.Customer.GetAllOwners();
                _logger.LogInfo($"Returned all customer from database.");

                var customerResult = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
                return Ok(customerResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllCustomers action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

