using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables : CVariable
	{
		private CUInt8 _u8;
		private CUInt16 _u16;
		private CUInt32 _u32;
		private CUInt64 _u64;
		private CInt8 _i8;
		private CInt16 _i16;
		private CInt32 _i32;
		private CInt64 _i64;
		private CUInt8 _aByte;
		private CInt32 _aInt;
		private CFloat _f;
		private CDouble _d;
		private CFloat _aliasedF;
		private CDouble _aliasedD;
		private CBool _b;
		private CString _str;
		private CString _aliasedStr;
		private CName _cName;
		private CName _aliasedCName;
		private Ref_6_ReplicatedVariables_SubStructure _subStruct;
		private Vector4 _replicatedVector4;
		private Quaternion _replicatedQuaternion;
		private EulerAngles _replicatedEulerAngles;
		private Transform _replicatedTransform;
		private CHandle<Ref_6_ReplicatedVariables_Class> _subObject;
		private wCHandle<Ref_6_ReplicatedVariables_Class> _ref_6_ReplicatedVariables_Class;
		private CArray<Ref_6_ReplicatedVariables_SubStructure> _dynArrayOfStructs;

		[Ordinal(0)] 
		[RED("u8")] 
		public CUInt8 U8
		{
			get => GetProperty(ref _u8);
			set => SetProperty(ref _u8, value);
		}

		[Ordinal(1)] 
		[RED("u16")] 
		public CUInt16 U16
		{
			get => GetProperty(ref _u16);
			set => SetProperty(ref _u16, value);
		}

		[Ordinal(2)] 
		[RED("u32")] 
		public CUInt32 U32
		{
			get => GetProperty(ref _u32);
			set => SetProperty(ref _u32, value);
		}

		[Ordinal(3)] 
		[RED("u64")] 
		public CUInt64 U64
		{
			get => GetProperty(ref _u64);
			set => SetProperty(ref _u64, value);
		}

		[Ordinal(4)] 
		[RED("i8")] 
		public CInt8 I8
		{
			get => GetProperty(ref _i8);
			set => SetProperty(ref _i8, value);
		}

		[Ordinal(5)] 
		[RED("i16")] 
		public CInt16 I16
		{
			get => GetProperty(ref _i16);
			set => SetProperty(ref _i16, value);
		}

		[Ordinal(6)] 
		[RED("i32")] 
		public CInt32 I32
		{
			get => GetProperty(ref _i32);
			set => SetProperty(ref _i32, value);
		}

		[Ordinal(7)] 
		[RED("i64")] 
		public CInt64 I64
		{
			get => GetProperty(ref _i64);
			set => SetProperty(ref _i64, value);
		}

		[Ordinal(8)] 
		[RED("aByte")] 
		public CUInt8 AByte
		{
			get => GetProperty(ref _aByte);
			set => SetProperty(ref _aByte, value);
		}

		[Ordinal(9)] 
		[RED("aInt")] 
		public CInt32 AInt
		{
			get => GetProperty(ref _aInt);
			set => SetProperty(ref _aInt, value);
		}

		[Ordinal(10)] 
		[RED("f")] 
		public CFloat F
		{
			get => GetProperty(ref _f);
			set => SetProperty(ref _f, value);
		}

		[Ordinal(11)] 
		[RED("d")] 
		public CDouble D
		{
			get => GetProperty(ref _d);
			set => SetProperty(ref _d, value);
		}

		[Ordinal(12)] 
		[RED("aliasedF")] 
		public CFloat AliasedF
		{
			get => GetProperty(ref _aliasedF);
			set => SetProperty(ref _aliasedF, value);
		}

		[Ordinal(13)] 
		[RED("aliasedD")] 
		public CDouble AliasedD
		{
			get => GetProperty(ref _aliasedD);
			set => SetProperty(ref _aliasedD, value);
		}

		[Ordinal(14)] 
		[RED("b")] 
		public CBool B
		{
			get => GetProperty(ref _b);
			set => SetProperty(ref _b, value);
		}

		[Ordinal(15)] 
		[RED("str")] 
		public CString Str
		{
			get => GetProperty(ref _str);
			set => SetProperty(ref _str, value);
		}

		[Ordinal(16)] 
		[RED("aliasedStr")] 
		public CString AliasedStr
		{
			get => GetProperty(ref _aliasedStr);
			set => SetProperty(ref _aliasedStr, value);
		}

		[Ordinal(17)] 
		[RED("cName")] 
		public CName CName
		{
			get => GetProperty(ref _cName);
			set => SetProperty(ref _cName, value);
		}

		[Ordinal(18)] 
		[RED("aliasedCName")] 
		public CName AliasedCName
		{
			get => GetProperty(ref _aliasedCName);
			set => SetProperty(ref _aliasedCName, value);
		}

		[Ordinal(19)] 
		[RED("subStruct")] 
		public Ref_6_ReplicatedVariables_SubStructure SubStruct
		{
			get => GetProperty(ref _subStruct);
			set => SetProperty(ref _subStruct, value);
		}

		[Ordinal(20)] 
		[RED("replicatedVector4")] 
		public Vector4 ReplicatedVector4
		{
			get => GetProperty(ref _replicatedVector4);
			set => SetProperty(ref _replicatedVector4, value);
		}

		[Ordinal(21)] 
		[RED("replicatedQuaternion")] 
		public Quaternion ReplicatedQuaternion
		{
			get => GetProperty(ref _replicatedQuaternion);
			set => SetProperty(ref _replicatedQuaternion, value);
		}

		[Ordinal(22)] 
		[RED("replicatedEulerAngles")] 
		public EulerAngles ReplicatedEulerAngles
		{
			get => GetProperty(ref _replicatedEulerAngles);
			set => SetProperty(ref _replicatedEulerAngles, value);
		}

		[Ordinal(23)] 
		[RED("replicatedTransform")] 
		public Transform ReplicatedTransform
		{
			get => GetProperty(ref _replicatedTransform);
			set => SetProperty(ref _replicatedTransform, value);
		}

		[Ordinal(24)] 
		[RED("subObject")] 
		public CHandle<Ref_6_ReplicatedVariables_Class> SubObject
		{
			get => GetProperty(ref _subObject);
			set => SetProperty(ref _subObject, value);
		}

		[Ordinal(25)] 
		[RED("Ref_6_ReplicatedVariables_Class")] 
		public wCHandle<Ref_6_ReplicatedVariables_Class> Ref_6_ReplicatedVariables_Class
		{
			get => GetProperty(ref _ref_6_ReplicatedVariables_Class);
			set => SetProperty(ref _ref_6_ReplicatedVariables_Class, value);
		}

		[Ordinal(26)] 
		[RED("dynArrayOfStructs")] 
		public CArray<Ref_6_ReplicatedVariables_SubStructure> DynArrayOfStructs
		{
			get => GetProperty(ref _dynArrayOfStructs);
			set => SetProperty(ref _dynArrayOfStructs, value);
		}

		public Ref_6_ReplicatedVariables(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
