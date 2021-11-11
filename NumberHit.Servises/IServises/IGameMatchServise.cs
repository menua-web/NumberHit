using NumberHit.Messages.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberHit.Servises.IServises
{
    public interface IGameMatchServise
    {
        StepMessage Step(string number);
    }
}
