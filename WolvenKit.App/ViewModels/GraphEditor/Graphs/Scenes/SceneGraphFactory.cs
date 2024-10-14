using System.Linq;
using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes;
using WolvenKit.App.ViewModels.GraphEditor.Scenes.Nodes.Internal;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Scenes;

public class SceneGraphFactory(ILoggerService log)
{
    public RedGraph Create(string title, scnSceneResource resource, GraphContext context)
    {
        var data = new GraphData(title, context);
        return new RedGraph(
            data,
            new SceneGraphService(data, resource, this, log),
            log
        );
    }

    public BaseSceneViewModel CreateView(scnSceneGraphNode graphNode, scnSceneResource resource)
    {
        BaseSceneViewModel view = graphNode switch
        {
            scnAndNode node => new scnAndNodeWrapper(node),
            scnChoiceNode node => new scnChoiceNodeWrapper(node, resource),
            scnCutControlNode node => new scnCutControlNodeWrapper(node),
            scnDeletionMarkerNode node => new scnDeletionMarkerNodeWrapper(node),
            scnEndNode node => CreateEndNodeView(node, resource),
            scnHubNode node => new scnHubNodeWrapper(node),
            scnInterruptManagerNode node => new scnInterruptManagerNodeWrapper(node),
            scnQuestNode node => new scnQuestNodeWrapper(node, resource),
            scnRandomizerNode node => new scnRandomizerNodeWrapper(node),
            scnRewindableSectionNode node => new scnRewindableSectionNodeWrapper(node, resource),
            scnSectionNode node => new scnSectionNodeWrapper(node, resource),
            scnStartNode node => CreateStartNodeView(node, resource),
            scnXorNode node => new scnXorNodeWrapper(node),
            _ => new scnSceneGraphNodeWrapper(graphNode)
        };

        view.GenerateSockets();
        return view;
    }

    private scnEndNodeWrapper CreateEndNodeView(scnEndNode endNode, scnSceneResource resource)
    {
        var endPoint = resource.ExitPoints.FirstOrDefault(x => x.NodeId.Id == endNode.NodeId.Id);

        if (endPoint == null)
        {
            endPoint = new scnExitPoint
            {
                NodeId = new scnNodeId
                {
                    Id = endNode.NodeId.Id
                }
            };
            resource.ExitPoints.Add(endPoint);
        }

        return new scnEndNodeWrapper(endNode, endPoint);
    }

    private scnStartNodeWrapper CreateStartNodeView(scnStartNode startNode, scnSceneResource resource)
    {
        var entryPoint = resource.EntryPoints.FirstOrDefault(x => x.NodeId.Id == startNode.NodeId.Id);

        if (entryPoint == null)
        {
            entryPoint = new scnEntryPoint
            {
                NodeId = new scnNodeId
                {
                    Id = startNode.NodeId.Id
                }
            };
            resource.EntryPoints.Add(entryPoint);
        }

        return new scnStartNodeWrapper(startNode, entryPoint);
    }
}