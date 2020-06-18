using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphComparatorNode : CBehaviorGraphValueNode
	{
		[RED("operation")] 		public CEnum<ECompareFunc> Operation { get; set;}

		[RED("firstValue")] 		public CFloat FirstValue { get; set;}

		[RED("secondValue")] 		public CFloat SecondValue { get; set;}

		[RED("trueValue")] 		public CFloat TrueValue { get; set;}

		[RED("falseValue")] 		public CFloat FalseValue { get; set;}

		[RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

		[RED("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSecondInputNode { get; set;}

		[RED("cachedTrueInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedTrueInputNode { get; set;}

		[RED("cachedFalseInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFalseInputNode { get; set;}

		public CBehaviorGraphComparatorNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphComparatorNode(cr2w);

	}
}