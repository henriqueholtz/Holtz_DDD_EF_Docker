using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.API.Controllers
{
    [Route("customer/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IApplicationServiceCustomers _applicationServiceCustomers;
        public CustomerController(IApplicationServiceCustomers applicationServiceCustomers)
        {
            _applicationServiceCustomers = applicationServiceCustomers;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCustomers.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return Ok(_applicationServiceCustomers.GetById(id));
        }

        [HttpPost]
        public ActionResult Add([FromBody] CustomerDto dto)
        {
            try
            {
                if (dto == null)
                    return NoContent();

                _applicationServiceCustomers.Add(dto);
                return Ok("Customer added succesfully!");

            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] CustomerDto dto)
        {
            try
            {
                if (dto == null)
                    return NoContent();

                _applicationServiceCustomers.Update(dto);
                return Ok("Customer updated succesfully!");

            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            try
            {
                _applicationServiceCustomers.Remove(id);
                return Ok("Customer removed succesfully!");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
