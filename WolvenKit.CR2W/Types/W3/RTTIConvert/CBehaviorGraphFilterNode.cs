using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphFilterNode : CBehaviorGraphBaseNode
	{
		[RED("filterTransform")] 		public CBool FilterTransform { get; set;}

		[RED("filterRotation")] 		public CBool FilterRotation { get; set;}

		[RED("filterScale")] 		public CBool FilterScale { get; set;}

		[RED("Bones with weights", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_weights { get; set;}

		[RED("cachedControlNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlNode { get; set;}

		public CBehaviorGraphFilterNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphFilterNode(cr2w);

	}
}