using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBehaviorGraphStateMachineNode : CBehaviorGraphContainerNode
	{
		[RED("globalTransitions", 2,0)] 		public CArray<CPtr<CBehaviorGraphStateTransitionGlobalBlendNode>> GlobalTransitions { get; set;}

		[RED("resetStateOnExit")] 		public CBool ResetStateOnExit { get; set;}

		[RED("applySyncTags")] 		public CBool ApplySyncTags { get; set;}

		public CBehaviorGraphStateMachineNode(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphStateMachineNode(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}