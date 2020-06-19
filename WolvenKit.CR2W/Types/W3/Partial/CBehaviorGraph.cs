using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBehaviorGraph : CResource
	{
		[RED("defaultStateMachine")] 		public CPtr<CBehaviorGraphStateMachineNode> DefaultStateMachine { get; set;}

		[RED("stateMachines", 2,0)] 		public CArray<CPtr<CBehaviorGraphStateMachineNode>> StateMachines { get; set;}

		[RED("sourceDataRemoved")] 		public CBool SourceDataRemoved { get; set;}

		[RED("customTrackNames", 2,0)] 		public CArray<CName> CustomTrackNames { get; set;}

		[RED("generateEditorFragments")] 		public CBool GenerateEditorFragments { get; set;}

		[RED("poseSlots", 2,0)] 		public CArray<CPtr<CBehaviorGraphPoseSlotNode>> PoseSlots { get; set;}

		[RED("animSlots", 2,0)] 		public CArray<CPtr<CBehaviorGraphAnimationBaseSlotNode>> AnimSlots { get; set;}

		public CBehaviorGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraph(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}