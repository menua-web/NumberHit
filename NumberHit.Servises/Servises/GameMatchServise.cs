using NumberHit.Messages.Game;
using NumberHit.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberHit.Servises.Servises
{
    public class GameMatchServise : IGameMatchServise
    {
        private readonly ICurrentCallContext _context;

        public GameMatchServise(ICurrentCallContext context)
        {
            _context = context;
        }

        public StepMessage Step(string number)
        {
            var result = new StepMessage();
            for (int i = 0; i < number.Length; i++)
            {
                var current = number[i];
                if (current == _context.Number[i])
                {
                    result.PossitionCount++;
                }

                if (_context.Number.Contains(current))
                {
                    result.MatchCount++;
                }
            }

            return result;
        }
    }
}
