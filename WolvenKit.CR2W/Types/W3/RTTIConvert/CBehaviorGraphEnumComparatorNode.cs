using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphEnumComparatorNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("enumValue")] 		public CVariant EnumValue { get; set;}

		[Ordinal(2)] [RED("operation")] 		public CEnum<ECompareFunc> Operation { get; set;}

		[Ordinal(3)] [RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

		public CBehaviorGraphEnumComparatorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphEnumComparatorNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}