using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.Nodify;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.Documents;

public partial class NodeViewModel : ObservableObject, INode<SocketViewModel>
{
    [ObservableProperty] private RDTGraphViewModel _graph;

    [ObservableProperty] private Point _location;

    [ObservableProperty] private bool _isSelected;

    public string? Header { get; set; }
    public Dictionary<string, string> Details { get; set; } = new();
    public string? Footer { get; set; }

    public IList<SocketViewModel> Inputs { get; set; } = new ObservableCollection<SocketViewModel>();
    public IList<SocketViewModel> Outputs { get; set; } = new ObservableCollection<SocketViewModel>();

    public graphGraphNodeDefinition RedNode { get; set; }

    public NodeViewModel(RDTGraphViewModel graph, graphGraphNodeDefinition node)
    {
        _graph = graph;
        RedNode = node;

        SetupNode(node);

        foreach (var socket in node.Sockets)
        {
            ArgumentNullException.ThrowIfNull(socket);
            var svm = new SocketViewModel(socket.Chunk.NotNull());

            bool isInput;
            if (socket.Chunk is questSocketDefinition qsd)
            {
                isInput = qsd.Type == Enums.questSocketType.Input || qsd.Type == Enums.questSocketType.CutDestination;
                if (qsd.Type == Enums.questSocketType.CutDestination || qsd.Type == Enums.questSocketType.CutSource)
                {
                    svm.Color = WkitBrushes.Purple;
                }
            }
            else
            {
                var n = socket.Chunk.Name.ToString();
                isInput = n is not null && ( n.Contains("In") || n.Contains("Source") );
            }
            if (isInput)
            {
                Inputs.Add(svm);
            }
            else
            {
                Outputs.Add(svm);
            }
            Graph.SocketLookup.Add(socket.Chunk.GetHashCode(), svm);
        }

        ((ObservableCollection<SocketViewModel>)Inputs).CollectionChanged += (sender, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems is not null)
            {
                foreach (SocketViewModel item in e.NewItems)
                {
                    item.Node = this;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems is not null)
            {
                foreach (SocketViewModel item in e.OldItems)
                {
                    item.Disconnect();
                }
            }
        };
        ((ObservableCollection<SocketViewModel>)Outputs).CollectionChanged += (sender, e) =>
        {
            if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems is not null)
            {
                foreach (SocketViewModel item in e.NewItems)
                {
                    item.Node = this;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove && e.OldItems is not null)
            {
                foreach (SocketViewModel item in e.OldItems)
                {
                    item.Disconnect();
                }
            }
        };
    }

    // TODO miroiu You could bind to the ActualSize of the ItemContainer if that's what you need here.
    public virtual Size GetSize()
    {
        var size = new Size(200, 0);
        if (Header != null)
        {
            size.Height += 23;
        }

        size.Height += Details.Count * 15;

        size.Height += Math.Max(Inputs.Count, Outputs.Count) * 19;

        if (Footer != null)
        {
            size.Height += 23;
        }
        return size;
    }

    private void SetupNode(graphGraphNodeDefinition node)
    {
        if (node is questInputNodeDefinition qind)
        {
            Header = qind.SocketName;
        }
        else if (node is questOutputNodeDefinition qond)
        {
            Header = qond.SocketName;
        }
        else if (node is questEventManagerNodeDefinition qemnd)
        {
            Header = qemnd.ManagerName;
        }
        else if (node is questCheckpointNodeDefinition qcpnd)
        {
            Header = qcpnd.DebugString;
        }
        else if (node is questPauseConditionNodeDefinition or questConditionNodeDefinition)
        {
            questIBaseCondition? condition = null;
            if (node is questPauseConditionNodeDefinition qpcnd)
            {
                Header = "Pause ";
                condition = qpcnd.Condition.Chunk;
            }
            else if (node is questConditionNodeDefinition qcnd)
            {
                Header = "";
                condition = qcnd.Condition.Chunk;
            }

            if (condition is questTriggerCondition qtc)
            {
                Header += "Trigger Condition";
                Details["Trigger Area"] = qtc.TriggerAreaRef.GetResolvedText().NotNull();
                Details["Type"] = qtc.Type.ToEnumString();
            }
            else if (condition is questObjectCondition qoc)
            {
                Header += "Object Condition";
                if (qoc.Type.Chunk is questDevice_ConditionType qdct)
                {
                    Details["Object"] = qdct.ObjectRef.GetResolvedText().NotNull();
                    Details["Class"] = qdct.DeviceControllerClass.ToString().NotNull();
                    Details["Function"] = qdct.DeviceConditionFunction.ToString().NotNull();
                }
            }
            else if (condition is questFactsDBCondition qfc)
            {
                Header += "FactsDB Condition";
                if (qfc.Type.Chunk is questVarComparison_ConditionType qvc)
                {
                    Header += " - Compare";
                    Details["Name"] = qvc.FactName;
                    Details["Comparison"] = qvc.ComparisonType.ToEnumString();
                    Details["Value"] = qvc.Value.ToString();
                }
            }
            else if (condition is questSpawnerCondition qsc)
            {
                Header += "Spawner Condition";
                if (qsc.Type.Chunk is questSpawnerReady_ConditionType qsrct)
                {
                    Header += " - Is Ready";
                    Details["Reference"] = qsrct.SpawnerReference.GetResolvedText().NotNull();
                }
            }
            else if (condition is questCharacterCondition qcc)
            {
                Header += "Character Condition";
                if (qcc.Type.Chunk is questCharacterMount_ConditionType qcmct)
                {
                    Header += " - Is Mounted";
                    Details["Parent Ref"] = qcmct.ParentRef.Reference.GetResolvedText().NotNull();
                }
            }
            else
            {
                Header += "Condition";
            }
        }
        else if (node is questSpawnManagerNodeDefinition qsmnd)
        {
            Header = "Spawn Manager";
            foreach (var action in qsmnd.Actions)
            {
                ArgumentNullException.ThrowIfNull(action);
                Header += " - " + action.Type.Chunk.NotNull().Action.ToEnumString();
            }
        }
        else if (node is questFactsDBManagerNodeDefinition qfmnd)
        {
            Header = "FactsDB Manager";
            if (qfmnd.Type.Chunk is questSetVar_NodeType qsvnt)
            {
                Header += " - Set";
                Details["Name"] = qsvnt.FactName;
                Details["Value"] = qsvnt.Value.ToString();
            }
        }
        else
        {
            Header = node.GetType().Name.Replace("quest", "").Replace("NodeDefinition", "");
        }

        Footer = node.GetType().Name;
        if (node is questNodeDefinition qnd)
        {
            Footer += $" [{qnd.Id}]";
        }
    }



    public void Disconnect()
    {
        Inputs.Clear();
        Outputs.Clear();
    }
}
