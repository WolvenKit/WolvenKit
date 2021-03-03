using DynamicData;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WolvenKit.Functionality.WKitGlobal.Helpers
{
    public class NodeNetworkHelper
    {
        public enum NodeType
        {
            StartNode, SceneNode, PhaseNode, InputNode,
            OutputNode, DeletionNode, PauseNode, InteractiveObjectManagerNode,
            DeviceManagerNode, ConditionNode, QuestNode, HubNode,
            EndNode, ChoiceNode, SectionNode, RandomizerNode,
            XorNode, FactsDBManagerNode, LogicalHubNode, WorldDataManagerNode,
            AudioNode, TeleportPuppetNode, UIManagerNode, RenderFXNode,
            LogicalXorNode, RewardManagerNode, CheckpointNode, CharacterManagerNode,
            PhoneManagerNode, CutControlNode,
        }


        public class Node_Template
        {
            //  public string Name;
            //  public Color Color;
            //  public List<NodeType> Sockets = new List<NodeType>();

        }
    }



    public class CustomNode : NodeViewModel
    {
        //public Color nodecolor;


        //public CustomNode(
        //    string NodeName,
        //    Color NodeColor,
        //    string NodeDescription,
        //    string NodeFamily,



        //    List<ValueNodeInputViewModel<Type>> InputSockets,
        //    List<ValueNodeOutputViewModel<Type>> OutputSockets)
        //{
        //    this.Name = NodeName;
        //    nodecolor = NodeColor;


        //    foreach (var InSocket in InputSockets)
        //    {
        //        this.Inputs.Add(InSocket);
        //    }


        //    foreach (var OutSocket in OutputSockets)
        //    {
        //        this.Outputs.Add(OutSocket);
        //    }


        //}
    }



}
