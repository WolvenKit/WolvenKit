using System;
using WolvenKit.App.Services;
using WolvenKit.Common;

namespace WolvenKit.App.Controllers;

public interface IGameControllerFactory
{
    public IGameController GetController();

    public RED4Controller GetRed4Controller();
}


public class GameControllerFactory : IGameControllerFactory
{
    //private readonly Tw3Controller _tw3Controller;
    private readonly RED4Controller _cp77Controller;
    private readonly MockGameController _mockGameController;
    private readonly IProjectManager _projectManager;

    private static GameControllerFactory? Instance;  
    public GameControllerFactory(
        IProjectManager projectManager,
        //Tw3Controller tw3Controller,
        RED4Controller cp77Controller,
        MockGameController mockGameController
        )
    {
        //_tw3Controller = tw3Controller;
        _cp77Controller = cp77Controller;
        _projectManager = projectManager;
        _mockGameController = mockGameController;

        Instance ??= this;
    }

    public static GameControllerFactory? GetInstance() => Instance;

    public static GameControllerFactory CreateInstance(
        IProjectManager projectManager,
        RED4Controller cp77Controller,
        MockGameController mockGameController
    ) => new GameControllerFactory(projectManager, cp77Controller, mockGameController);
    

    public RED4Controller GetRed4Controller() => _cp77Controller;

    public IGameController GetController() =>
        _projectManager.ActiveProject == null
            ? _mockGameController
            : Models.ProjectManagement.Project.Cp77Project.GameType switch
            {
                //GameType.Witcher3 => _tw3Controller,
                GameType.Cyberpunk2077 => _cp77Controller,
                _ => throw new ArgumentOutOfRangeException(
                    nameof(Models.ProjectManagement.Project.Cp77Project.GameType),
                    Models.ProjectManagement.Project.Cp77Project.GameType, null)
            };
}
