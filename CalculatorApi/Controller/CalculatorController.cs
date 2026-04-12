using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Services;
namespace CalculatorApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _service = new CalculatorService();

    [HttpGet("add")]
    public int Add(int a, int b) => _service.Add(a, b);

    [HttpGet("subtract")]
    public int Subtract(int a, int b) => _service.Subtract(a, b);
    }
}