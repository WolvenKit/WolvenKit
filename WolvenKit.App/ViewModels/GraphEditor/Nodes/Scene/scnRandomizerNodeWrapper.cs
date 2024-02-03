using WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene.Internal;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Scene;

public class scnRandomizerNodeWrapper : BaseSceneViewModel<scnRandomizerNode>, IDynamicOutputNode
{
    public scnRandomizerNodeWrapper(scnRandomizerNode scnRandomizerNode) : base(scnRandomizerNode)
    {
        InputSocketNames.Add(0, "In");
        InputSocketNames.Add(1, "Cancel");

        OutputSocketNames.Add(0, "Out");
    }

    internal override void GenerateSockets()
    {
        Input.Clear();
        foreach (var (socketNameId, socketName) in InputSocketNames)
        {
            Input.Add(new SceneInputConnectorViewModel(socketName, socketName, UniqueId, socketNameId, 0));
        }

        var names = new string[_castedData.NumOutSockets];

        var total = 0;
        for (var i = 0; i < _castedData.NumOutSockets; i++)
        {
            total += _castedData.Weights[i];
        }

        for (var i = 0; i < _castedData.NumOutSockets; i++)
        {
            var chance = (float)_castedData.Weights[i] / total * 100;
            names[i] = $"[{chance:0.00}%] Out{i}";
        }

        Output.Clear();
        for (var i = 0; i < _castedData.OutputSockets.Count; i++)
        {
            Output.Add(new SceneOutputConnectorViewModel(names[i], names[i], UniqueId, _castedData.OutputSockets[i]));
        }
    }

    public BaseConnectorViewModel AddOutput()
    {
        var index = (ushort)Output.Count;
        var outputSocket = new scnOutputSocket { Stamp = new scnOutputSocketStamp { Name = 0, Ordinal = index } };

        _castedData.OutputSockets.Add(outputSocket);

        var output = new SceneOutputConnectorViewModel($"Out{index}", $"Out{index}", UniqueId, outputSocket);
        Output.Add(output);

        _castedData.NumOutSockets = (uint)Output.Count;

        return output;
    }

    public void RemoveOutput() => throw new System.NotImplementedException();
}