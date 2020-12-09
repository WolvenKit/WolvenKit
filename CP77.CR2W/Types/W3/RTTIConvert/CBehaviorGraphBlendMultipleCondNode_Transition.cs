using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendMultipleCondNode_Transition : CObject
	{
		[Ordinal(1)] [RED("condition")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_Condition> Condition { get; set;}

		[Ordinal(2)] [RED("transitionDuration")] 		public CFloat TransitionDuration { get; set;}

		[Ordinal(3)] [RED("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(4)] [RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(5)] [RED("blockEvents")] 		public CBool BlockEvents { get; set;}

		[Ordinal(6)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		public CBehaviorGraphBlendMultipleCondNode_Transition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendMultipleCondNode_Transition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}