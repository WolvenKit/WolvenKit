using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMapRangeNode : CBehaviorGraphValueBaseNode
	{
		[RED("minInValue")] 		public CFloat MinInValue { get; set;}

		[RED("maxInValue")] 		public CFloat MaxInValue { get; set;}

		[RED("minOutValue")] 		public CFloat MinOutValue { get; set;}

		[RED("maxOutValue")] 		public CFloat MaxOutValue { get; set;}

		[RED("base")] 		public CFloat Base { get; set;}

		[RED("bias")] 		public CFloat Bias { get; set;}

		public CBehaviorGraphMapRangeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMapRangeNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}