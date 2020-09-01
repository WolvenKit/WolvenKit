using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSyncOverrideStateMachineNode : CBehaviorGraphSelfActivatingStateMachineNode
	{
		[Ordinal(0)] [RED("rootBoneName")] 		public CString RootBoneName { get; set;}

		[Ordinal(0)] [RED("blendRootParent")] 		public CBool BlendRootParent { get; set;}

		[Ordinal(0)] [RED("defaultWeight")] 		public CFloat DefaultWeight { get; set;}

		[Ordinal(0)] [RED("mergeEvents")] 		public CBool MergeEvents { get; set;}

		public CBehaviorGraphSyncOverrideStateMachineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSyncOverrideStateMachineNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}