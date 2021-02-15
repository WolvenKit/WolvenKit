using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_All_Supported_Replicated_Types : CVariable
	{
		[Ordinal(0)] [RED("bool")] public CBool Bool { get; set; }
		[Ordinal(1)] [RED("uint8")] public CUInt8 Uint8 { get; set; }
		[Ordinal(2)] [RED("int8")] public CInt8 Int8 { get; set; }
		[Ordinal(3)] [RED("uint16")] public CUInt16 Uint16 { get; set; }
		[Ordinal(4)] [RED("int16")] public CInt16 Int16 { get; set; }
		[Ordinal(5)] [RED("uint32")] public CUInt32 Uint32 { get; set; }
		[Ordinal(6)] [RED("int32")] public CInt32 Int32 { get; set; }
		[Ordinal(7)] [RED("uint64")] public CUInt64 Uint64 { get; set; }
		[Ordinal(8)] [RED("int64")] public CInt64 Int64 { get; set; }
		[Ordinal(9)] [RED("float")] public CFloat Float { get; set; }
		[Ordinal(10)] [RED("double")] public CDouble Double { get; set; }
		[Ordinal(11)] [RED("name")] public CName Name { get; set; }
		[Ordinal(12)] [RED("string")] public CString String { get; set; }
		[Ordinal(13)] [RED("enum")] public CEnum<Sample_Replicated_Enum> Enum { get; set; }
		[Ordinal(14)] [RED("struct")] public Sample_Replicated_Struct Struct { get; set; }
		[Ordinal(15)] [RED("dynamicArray")] public CArray<Sample_Replicated_Struct> DynamicArray { get; set; }
		[Ordinal(16)] [RED("staticArray", 10)] public CStatic<Sample_Replicated_Struct> StaticArray { get; set; }
		[Ordinal(17)] [RED("THandle")] public CHandle<Sample_Replicated_Serializable> THandle { get; set; }

		public Sample_All_Supported_Replicated_Types(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
