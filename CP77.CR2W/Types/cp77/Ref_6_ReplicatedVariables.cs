using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables : CVariable
	{
		[Ordinal(0)]  [RED("Ref_6_ReplicatedVariables_Class")] public wCHandle<Ref_6_ReplicatedVariables_Class> Ref_6_ReplicatedVariables_Class { get; set; }
		[Ordinal(1)]  [RED("aByte")] public CUInt8 AByte { get; set; }
		[Ordinal(2)]  [RED("aInt")] public CInt32 AInt { get; set; }
		[Ordinal(3)]  [RED("aliasedCName")] public CName AliasedCName { get; set; }
		[Ordinal(4)]  [RED("aliasedD")] public CDouble AliasedD { get; set; }
		[Ordinal(5)]  [RED("aliasedF")] public CFloat AliasedF { get; set; }
		[Ordinal(6)]  [RED("aliasedStr")] public CString AliasedStr { get; set; }
		[Ordinal(7)]  [RED("b")] public CBool B { get; set; }
		[Ordinal(8)]  [RED("cName")] public CName CName { get; set; }
		[Ordinal(9)]  [RED("d")] public CDouble D { get; set; }
		[Ordinal(10)]  [RED("dynArrayOfStructs")] public CArray<Ref_6_ReplicatedVariables_SubStructure> DynArrayOfStructs { get; set; }
		[Ordinal(11)]  [RED("f")] public CFloat F { get; set; }
		[Ordinal(12)]  [RED("i16")] public CInt16 I16 { get; set; }
		[Ordinal(13)]  [RED("i32")] public CInt32 I32 { get; set; }
		[Ordinal(14)]  [RED("i64")] public CInt64 I64 { get; set; }
		[Ordinal(15)]  [RED("i8")] public CInt8 I8 { get; set; }
		[Ordinal(16)]  [RED("replicatedEulerAngles")] public EulerAngles ReplicatedEulerAngles { get; set; }
		[Ordinal(17)]  [RED("replicatedQuaternion")] public Quaternion ReplicatedQuaternion { get; set; }
		[Ordinal(18)]  [RED("replicatedTransform")] public Transform ReplicatedTransform { get; set; }
		[Ordinal(19)]  [RED("replicatedVector4")] public Vector4 ReplicatedVector4 { get; set; }
		[Ordinal(20)]  [RED("str")] public CString Str { get; set; }
		[Ordinal(21)]  [RED("subObject")] public CHandle<Ref_6_ReplicatedVariables_Class> SubObject { get; set; }
		[Ordinal(22)]  [RED("subStruct")] public Ref_6_ReplicatedVariables_SubStructure SubStruct { get; set; }
		[Ordinal(23)]  [RED("u16")] public CUInt16 U16 { get; set; }
		[Ordinal(24)]  [RED("u32")] public CUInt32 U32 { get; set; }
		[Ordinal(25)]  [RED("u64")] public CUInt64 U64 { get; set; }
		[Ordinal(26)]  [RED("u8")] public CUInt8 U8 { get; set; }

		public Ref_6_ReplicatedVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
