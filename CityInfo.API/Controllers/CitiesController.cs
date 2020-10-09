﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}