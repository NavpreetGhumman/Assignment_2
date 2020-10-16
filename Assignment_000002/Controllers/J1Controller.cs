using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_000002.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Pick number from 1 to 4 to choose your meal then calculate and display the total calories
        /// </summary>
        /// <param name="burger">input to select the burger</param>
        /// <param name="drink">input to select the drink</param>
        /// <param name="side">input to select the side</param>
        /// <param name="dessert">input to select the dessert</param>
        /// <example>
        /// api/J1/Menu/4/4/4/4    -->   "Your total calorie count is 0"
        /// </example>
        /// <example>
        /// api/J1/Menu/1/2/3/4    -->   "Your total calorie count is 691"
        /// </example>
        /// <returns>Return the total calories of the meal</returns>


        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int calories;
            if (burger == 1)
            {
                calories = 461;
            }
            else if (burger == 2)
            {
                calories = 431;
            }
            else if (burger == 3)
            {
                calories = 420;
            }
            else
            {
                calories = 0;
            }

            if (drink == 1)
            {
                calories = calories + 130;
            }
            else if (drink == 2)
            {
                calories = calories + 160;
            }
            else if (drink == 3)
            {
                calories = calories + 180;
            }
            else
            {
                calories = calories + 0;
            }

            if (side == 1)
            {
                calories = side + 100;
            }
            else if (side == 2)
            {
                calories = calories + 57;
            }
            else if (side == 3)
            {
                calories = calories + 70;
            }
            else
            {
                calories = calories + 0;
            }

            if (dessert == 1)
            {
                calories = side + 167;
            }
            else if (dessert == 2)
            {
                calories = calories + 266;
            }
            else if (dessert == 3)
            {
                calories = calories + 75;
            }
            else
            {
                calories = calories + 0;
            }

            return "Your total calorie count is " + calories;
        }
    }
}
