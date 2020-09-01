using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphComparatorNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("("operation")] 		public CEnum<ECompareFunc> Operation { get; set;}

		[Ordinal(2)] [RED("("firstValue")] 		public CFloat FirstValue { get; set;}

		[Ordinal(3)] [RED("("secondValue")] 		public CFloat SecondValue { get; set;}

		[Ordinal(4)] [RED("("trueValue")] 		public CFloat TrueValue { get; set;}

		[Ordinal(5)] [RED("("falseValue")] 		public CFloat FalseValue { get; set;}

		[Ordinal(6)] [RED("("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

		[Ordinal(7)] [RED("("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSecondInputNode { get; set;}

		[Ordinal(8)] [RED("("cachedTrueInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedTrueInputNode { get; set;}

		[Ordinal(9)] [RED("("cachedFalseInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFalseInputNode { get; set;}

		public CBehaviorGraphComparatorNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphComparatorNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}