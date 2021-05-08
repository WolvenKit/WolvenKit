using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;

namespace WolvenKit.Functionality.Controllers
{
    public interface IGameControllerFactory
    {
        public IGameController GetController();
    }


    public class GameControllerFactory : IGameControllerFactory
    {
        private readonly Tw3Controller _tw3Controller;
        private readonly Cp77Controller _cp77Controller;
        private readonly MockGameController _mockGameController;
        private readonly IProjectManager _projectManager;



        public GameControllerFactory(
            IProjectManager projectManager,
            Tw3Controller tw3Controller,
            Cp77Controller cp77Controller,
            MockGameController mockGameController
            )
        {
            _tw3Controller = tw3Controller;
            _cp77Controller = cp77Controller;
            _projectManager = projectManager;
            _mockGameController = mockGameController;
        }

        public IGameController GetController() =>
            _projectManager.ActiveProject == null
                ? _mockGameController
                : _projectManager.ActiveProject.GameType switch
                {
                    GameType.Witcher3 => _tw3Controller,
                    GameType.Cyberpunk2077 => _cp77Controller,
                    _ => throw new ArgumentOutOfRangeException(
                        nameof(_projectManager.ActiveProject.GameType),
                        _projectManager.ActiveProject.GameType, null)
                };
    }
}
