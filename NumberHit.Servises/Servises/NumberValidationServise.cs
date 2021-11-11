using NumberHit.Messages.Validation;
using NumberHit.Servises.IServises;
using System;

namespace NumberHit.Servises.Servises
{
    public class NumberValidationServise : INumberValidationServise
    {
        public ValidationMessage ValidateNumber(string number)
        {
            var result = new ValidationMessage();
            if (String.IsNullOrWhiteSpace(number))
            {
                result.Add("Number cannot be empty or null.");
            }

            if (number.Length != 4)
            {
                result.Add("Number length most be 4.");
            }


            for (int i = 0; i < 4; i++)
            {
                var currNum = number[i];
                for (int j = i + 1; j < 4; j++)
                {
                    if (number[j] == currNum)
                    {
                        result.Add("Number most contains non reapited numbers.");
                    }
                }
            }

            return result;
        }
    }
}
