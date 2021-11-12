using NumberHit.Enums;
using NumberHit.Messages.Game;
using NumberHit.Servises.IServises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberHit.Servises.Servises
{
    public class GameService : IGameService
    {

        private readonly INumberGeneratorService _numberGeneratorService;
        public GameService(INumberGeneratorService numberGeneratorService)
        {
            _numberGeneratorService = numberGeneratorService;
        }

        public GameState State { get; private set; }

        public string UserNumber { get; private set; }

        public string ServerNumber { get; private set; }

        public void ChangeStateTo(GameState gameState)
        {
            State = gameState;
        }

        public void Restart()
        {
            State = GameState.None;
        }

        public void SetServerNumber(string number)
        {
            ServerNumber = number;
        }

        public void SetUserNumber(string number)
        {
            UserNumber = number;
        }

        public void Start(StartOptions options)
        {
            State = GameState.Started;
            ServerNumber = _numberGeneratorService.GenerateGameNumber();
            UserNumber = options.UserNumber;
        }
    }
}
