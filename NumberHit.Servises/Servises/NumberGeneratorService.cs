using NumberHit.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberHit.Servises.Servises
{
    public class NumberGeneratorService : INumberGeneratorService
    {
        public string GenerateGameNumber()
        {
            var response = String.Empty;
            var random = new Random();
            while (response.Length < 4)
            {
                var number = random.Next(0, 10).ToString();
                if (!response.Contains(number))
                {
                    response += number;
                }
            }

            return response;
        }
    }
}
