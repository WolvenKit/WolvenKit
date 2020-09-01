using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphGetBoneTransformNode : CBehaviorGraphVectorValueNode
	{
		[Ordinal(1)] [RED("("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("("type")] 		public CEnum<ETransformType> Type { get; set;}

		[Ordinal(3)] [RED("("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphGetBoneTransformNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphGetBoneTransformNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}