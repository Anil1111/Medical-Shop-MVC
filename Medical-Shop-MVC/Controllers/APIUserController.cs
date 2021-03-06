﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medical_Shop_MVC.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Shop_MVC.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class APIUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public APIUserController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/APIUser
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/APIUser/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
