using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3QuestCond_ActorRotationToNode : CQCActorScriptedCondition
	{
		[RED("condition")] 		public CEnum<ECompareOp> Condition { get; set;}

		[RED("degrees")] 		public CFloat Degrees { get; set;}

		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("targetNode")] 		public CHandle<CNode> TargetNode { get; set;}

		[RED("listener")] 		public CHandle<W3QuestCond_ActorRotationToNode_Listener> Listener { get; set;}

		public W3QuestCond_ActorRotationToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3QuestCond_ActorRotationToNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}