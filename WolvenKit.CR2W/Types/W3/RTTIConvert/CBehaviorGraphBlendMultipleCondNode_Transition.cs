using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendMultipleCondNode_Transition : CObject
	{
		[RED("condition")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_Condition> Condition { get; set;}

		[RED("transitionDuration")] 		public CFloat TransitionDuration { get; set;}

		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("blockEvents")] 		public CBool BlockEvents { get; set;}

		[RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		public CBehaviorGraphBlendMultipleCondNode_Transition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphBlendMultipleCondNode_Transition(cr2w);

	}
}