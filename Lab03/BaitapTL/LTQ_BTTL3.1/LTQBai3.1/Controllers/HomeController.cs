using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQBai3._1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PrimeNumbers()
        {
            List<int> primeNumbers = new List<int>();

            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }

            return View(primeNumbers);
        }

        public ActionResult Factorials()
        {
            List<int> factorials = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                factorials.Add(factorial);
            }

            return View(factorials);
        }

        public ActionResult MultiplicationTable()
        {
            Dictionary<int, List<int>> multiplicationTable = new Dictionary<int, List<int>>();

            for (int i = 2; i <= 9; i++)
            {
                List<int> row = new List<int>();
                for (int j = 1; j <= 10; j++)
                {
                    row.Add(i * j);
                }
                multiplicationTable.Add(i, row);
            }

            return View(multiplicationTable);
        }
    }
}

