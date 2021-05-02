using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMapRangeNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("minInValue")] 		public CFloat MinInValue { get; set;}

		[Ordinal(2)] [RED("maxInValue")] 		public CFloat MaxInValue { get; set;}

		[Ordinal(3)] [RED("minOutValue")] 		public CFloat MinOutValue { get; set;}

		[Ordinal(4)] [RED("maxOutValue")] 		public CFloat MaxOutValue { get; set;}

		[Ordinal(5)] [RED("base")] 		public CFloat Base { get; set;}

		[Ordinal(6)] [RED("bias")] 		public CFloat Bias { get; set;}

		public CBehaviorGraphMapRangeNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}