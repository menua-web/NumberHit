using NumberHit.Enums;
using NumberHit.Messages.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberHit.Servises.IServises
{
    public interface IGameService
    {
        public GameState State { get; }
        public string UserNumber { get; }
        public string ServerNumber { get; }

        public void ChangeStateTo(GameState gameState);
        public void SetUserNumber(string number);
        public void SetServerNumber(string number);

        public void Restart();
        public void Start(StartOptions options);
    }
}
