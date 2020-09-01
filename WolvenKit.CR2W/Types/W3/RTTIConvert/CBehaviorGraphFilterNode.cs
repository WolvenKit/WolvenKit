using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphFilterNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("filterTransform")] 		public CBool FilterTransform { get; set;}

		[Ordinal(0)] [RED("("filterRotation")] 		public CBool FilterRotation { get; set;}

		[Ordinal(0)] [RED("("filterScale")] 		public CBool FilterScale { get; set;}

		[Ordinal(0)] [RED("("Bones with weights", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones_with_weights { get; set;}

		[Ordinal(0)] [RED("("cachedControlNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlNode { get; set;}

		public CBehaviorGraphFilterNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphFilterNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}