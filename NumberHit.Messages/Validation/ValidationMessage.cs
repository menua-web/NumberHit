using System.Collections.Generic;
using System.Linq;

namespace NumberHit.Messages.Validation
{
    public class ValidationMessage
    {
        private List<string> Errors { get; } = new List<string>();
        public bool IsValid { get { return Errors.Any(); } }

        public void Add(string error)
        {
            Errors.Add(error);
        }

        public List<string> GetErrors()
        {
            return Errors;
        }
    }
}
