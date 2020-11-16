﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API_James.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore_API_James.Controllers
{
	/// <summary>
	/// This is a test API controller
	/// </summary>
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		private readonly ILoggerService _logger;

		public HomeController(ILoggerService logger){
			_logger = logger;
		}

		/// <summary>
		/// Gets values
		/// </summary>
		/// <returns></returns>
		// GET: api/<HomeController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			_logger.LogInfo("Accessed Home Controller");
			return new string[] { "value1", "value2" };
		}

		/// <summary>
		/// Gets a value based on id parameter
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		// GET api/<HomeController>/5
		[HttpGet("{id}", Name = "Get")]
		public string Get(int id)
		{
			_logger.LogDebug("Got a value");
			return "value";
		}

		/// <returns></returns>
		// POST api/<HomeController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
			_logger.LogError("This is an error");
		}

		// PUT api/<HomeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<HomeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_logger.LogInfo("This is a warning");
		}
	}
}
