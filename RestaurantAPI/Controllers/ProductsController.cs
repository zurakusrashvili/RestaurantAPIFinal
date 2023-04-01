using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Contracts;
using RestaurantAPI.Models.Products;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductsRepository productsRepository, IMapper mapper)
        {
            this._productsRepository = productsRepository;
            this._mapper = mapper;
        }

        // GET: api/Products
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            var products = await _productsRepository.GetAllAsync();
            return Ok(_mapper.Map<List<ProductDto>>(products));
        }


        [HttpGet]
        [Route("GetFiltered")]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetFilteredProducts([FromQuery]bool? vegeterian, [FromQuery]bool? nuts, [FromQuery]int? spiciness, [FromQuery] int? categoryId)
        {
            var products = await _productsRepository.GetFiltered(vegeterian, nuts, spiciness, categoryId);
            
            return Ok(_mapper.Map<List<ProductDto>>(products));
        }
    }
}
