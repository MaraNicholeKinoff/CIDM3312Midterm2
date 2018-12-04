using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIDM3312Midterm2.Models;
using MathLibrary;

namespace CIDM3312Midterm2.Controllers
{
    public class MathController : Controller
    {
        [HttpGet]
        public IActionResult DoConversion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation mathOp)
        {
            switch(mathOp.Operator) {
                case "Addition":
                    mathOp.result = MathLibrary.MyMathLib.Add(mathOp.rightOperand, mathOp.leftOperand);
                    break;
                case "Subtraction":
                    mathOp.result = MathLibrary.MyMathLib.Subtract(mathOp.rightOperand, mathOp.leftOperand);
                    break;
                case "Multiplication":
                    mathOp.result = MathLibrary.MyMathLib.Multiply(mathOp.rightOperand, mathOp.leftOperand);
                    break;
                case "Division":
                    mathOp.result = MathLibrary.MyMathLib.Divide(mathOp.rightOperand, mathOp.leftOperand);
                    break;
                default:
                    Console.WriteLine("There was an error.");
                    break;              
            }
            return View(mathOp);
        }
    }
}
