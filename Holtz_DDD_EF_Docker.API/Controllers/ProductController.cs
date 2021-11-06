using Holtz_DDD_EF_Docker.Application.Dtos;
using Holtz_DDD_EF_Docker.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Holtz_DDD_EF_Docker.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProducts _applicationServiceProducts;
        public ProductController(IApplicationServiceProducts applicationServiceProducts)
        {
            _applicationServiceProducts = applicationServiceProducts;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProducts.GetAll());
        }


        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return Ok(_applicationServiceProducts.GetById(id));
        }

        [HttpPost]
        public ActionResult Add([FromBody] ProductDto dto)
        {
            try
            {
                if (dto == null)
                    return NoContent();

                _applicationServiceProducts.Add(dto);
                return Ok("Product added succesfully!");

            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] ProductDto dto)
        {
            try
            {
                if (dto == null)
                    return NoContent();

                _applicationServiceProducts.Update(dto);
                return Ok("Product updated succesfully!");

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
                _applicationServiceProducts.Remove(id);
                return Ok("Product removed succesfully!");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
