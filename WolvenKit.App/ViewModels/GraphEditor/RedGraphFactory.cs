using System;
using WolvenKit.App.ViewModels.GraphEditor.Null;
using WolvenKit.App.ViewModels.GraphEditor.Quests;
using WolvenKit.App.ViewModels.GraphEditor.Scenes;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor;

public class RedGraphFactory(
    Lazy<QuestGraphFactory> questFactory,
    Lazy<SceneGraphFactory> sceneFactory,
    NullGraphFactory nullFactory)
{
    public RedGraph Create(string title, IRedType data, GraphContext context)
    {
        return data switch
        {
            questQuestPhaseResource resource => questFactory.Value.Create(title, resource, context),
            scnSceneResource resource => sceneFactory.Value.Create(title, resource, context),
            _ => nullFactory.Create(title, context),
        };
    }
}