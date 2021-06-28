using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_Fact : W3SwitchEvent
	{
		[Ordinal(1)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(2)] [RED("operation")] 		public CEnum<EFactOperation> Operation { get; set;}

		[Ordinal(3)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(4)] [RED("validFor")] 		public CInt32 ValidFor { get; set;}

		public W3SE_Fact(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}