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
			get
			{
				if (_u8 == null)
				{
					_u8 = (CUInt8) CR2WTypeManager.Create("Uint8", "u8", cr2w, this);
				}
				return _u8;
			}
			set
			{
				if (_u8 == value)
				{
					return;
				}
				_u8 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("u16")] 
		public CUInt16 U16
		{
			get
			{
				if (_u16 == null)
				{
					_u16 = (CUInt16) CR2WTypeManager.Create("Uint16", "u16", cr2w, this);
				}
				return _u16;
			}
			set
			{
				if (_u16 == value)
				{
					return;
				}
				_u16 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("u32")] 
		public CUInt32 U32
		{
			get
			{
				if (_u32 == null)
				{
					_u32 = (CUInt32) CR2WTypeManager.Create("Uint32", "u32", cr2w, this);
				}
				return _u32;
			}
			set
			{
				if (_u32 == value)
				{
					return;
				}
				_u32 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("u64")] 
		public CUInt64 U64
		{
			get
			{
				if (_u64 == null)
				{
					_u64 = (CUInt64) CR2WTypeManager.Create("Uint64", "u64", cr2w, this);
				}
				return _u64;
			}
			set
			{
				if (_u64 == value)
				{
					return;
				}
				_u64 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("i8")] 
		public CInt8 I8
		{
			get
			{
				if (_i8 == null)
				{
					_i8 = (CInt8) CR2WTypeManager.Create("Int8", "i8", cr2w, this);
				}
				return _i8;
			}
			set
			{
				if (_i8 == value)
				{
					return;
				}
				_i8 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("i16")] 
		public CInt16 I16
		{
			get
			{
				if (_i16 == null)
				{
					_i16 = (CInt16) CR2WTypeManager.Create("Int16", "i16", cr2w, this);
				}
				return _i16;
			}
			set
			{
				if (_i16 == value)
				{
					return;
				}
				_i16 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("i32")] 
		public CInt32 I32
		{
			get
			{
				if (_i32 == null)
				{
					_i32 = (CInt32) CR2WTypeManager.Create("Int32", "i32", cr2w, this);
				}
				return _i32;
			}
			set
			{
				if (_i32 == value)
				{
					return;
				}
				_i32 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("i64")] 
		public CInt64 I64
		{
			get
			{
				if (_i64 == null)
				{
					_i64 = (CInt64) CR2WTypeManager.Create("Int64", "i64", cr2w, this);
				}
				return _i64;
			}
			set
			{
				if (_i64 == value)
				{
					return;
				}
				_i64 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("aByte")] 
		public CUInt8 AByte
		{
			get
			{
				if (_aByte == null)
				{
					_aByte = (CUInt8) CR2WTypeManager.Create("Uint8", "aByte", cr2w, this);
				}
				return _aByte;
			}
			set
			{
				if (_aByte == value)
				{
					return;
				}
				_aByte = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("aInt")] 
		public CInt32 AInt
		{
			get
			{
				if (_aInt == null)
				{
					_aInt = (CInt32) CR2WTypeManager.Create("Int32", "aInt", cr2w, this);
				}
				return _aInt;
			}
			set
			{
				if (_aInt == value)
				{
					return;
				}
				_aInt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("f")] 
		public CFloat F
		{
			get
			{
				if (_f == null)
				{
					_f = (CFloat) CR2WTypeManager.Create("Float", "f", cr2w, this);
				}
				return _f;
			}
			set
			{
				if (_f == value)
				{
					return;
				}
				_f = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("d")] 
		public CDouble D
		{
			get
			{
				if (_d == null)
				{
					_d = (CDouble) CR2WTypeManager.Create("Double", "d", cr2w, this);
				}
				return _d;
			}
			set
			{
				if (_d == value)
				{
					return;
				}
				_d = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("aliasedF")] 
		public CFloat AliasedF
		{
			get
			{
				if (_aliasedF == null)
				{
					_aliasedF = (CFloat) CR2WTypeManager.Create("Float", "aliasedF", cr2w, this);
				}
				return _aliasedF;
			}
			set
			{
				if (_aliasedF == value)
				{
					return;
				}
				_aliasedF = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("aliasedD")] 
		public CDouble AliasedD
		{
			get
			{
				if (_aliasedD == null)
				{
					_aliasedD = (CDouble) CR2WTypeManager.Create("Double", "aliasedD", cr2w, this);
				}
				return _aliasedD;
			}
			set
			{
				if (_aliasedD == value)
				{
					return;
				}
				_aliasedD = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("b")] 
		public CBool B
		{
			get
			{
				if (_b == null)
				{
					_b = (CBool) CR2WTypeManager.Create("Bool", "b", cr2w, this);
				}
				return _b;
			}
			set
			{
				if (_b == value)
				{
					return;
				}
				_b = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("str")] 
		public CString Str
		{
			get
			{
				if (_str == null)
				{
					_str = (CString) CR2WTypeManager.Create("String", "str", cr2w, this);
				}
				return _str;
			}
			set
			{
				if (_str == value)
				{
					return;
				}
				_str = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("aliasedStr")] 
		public CString AliasedStr
		{
			get
			{
				if (_aliasedStr == null)
				{
					_aliasedStr = (CString) CR2WTypeManager.Create("String", "aliasedStr", cr2w, this);
				}
				return _aliasedStr;
			}
			set
			{
				if (_aliasedStr == value)
				{
					return;
				}
				_aliasedStr = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("cName")] 
		public CName CName
		{
			get
			{
				if (_cName == null)
				{
					_cName = (CName) CR2WTypeManager.Create("CName", "cName", cr2w, this);
				}
				return _cName;
			}
			set
			{
				if (_cName == value)
				{
					return;
				}
				_cName = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("aliasedCName")] 
		public CName AliasedCName
		{
			get
			{
				if (_aliasedCName == null)
				{
					_aliasedCName = (CName) CR2WTypeManager.Create("CName", "aliasedCName", cr2w, this);
				}
				return _aliasedCName;
			}
			set
			{
				if (_aliasedCName == value)
				{
					return;
				}
				_aliasedCName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("subStruct")] 
		public Ref_6_ReplicatedVariables_SubStructure SubStruct
		{
			get
			{
				if (_subStruct == null)
				{
					_subStruct = (Ref_6_ReplicatedVariables_SubStructure) CR2WTypeManager.Create("Ref_6_ReplicatedVariables_SubStructure", "subStruct", cr2w, this);
				}
				return _subStruct;
			}
			set
			{
				if (_subStruct == value)
				{
					return;
				}
				_subStruct = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("replicatedVector4")] 
		public Vector4 ReplicatedVector4
		{
			get
			{
				if (_replicatedVector4 == null)
				{
					_replicatedVector4 = (Vector4) CR2WTypeManager.Create("Vector4", "replicatedVector4", cr2w, this);
				}
				return _replicatedVector4;
			}
			set
			{
				if (_replicatedVector4 == value)
				{
					return;
				}
				_replicatedVector4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("replicatedQuaternion")] 
		public Quaternion ReplicatedQuaternion
		{
			get
			{
				if (_replicatedQuaternion == null)
				{
					_replicatedQuaternion = (Quaternion) CR2WTypeManager.Create("Quaternion", "replicatedQuaternion", cr2w, this);
				}
				return _replicatedQuaternion;
			}
			set
			{
				if (_replicatedQuaternion == value)
				{
					return;
				}
				_replicatedQuaternion = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("replicatedEulerAngles")] 
		public EulerAngles ReplicatedEulerAngles
		{
			get
			{
				if (_replicatedEulerAngles == null)
				{
					_replicatedEulerAngles = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "replicatedEulerAngles", cr2w, this);
				}
				return _replicatedEulerAngles;
			}
			set
			{
				if (_replicatedEulerAngles == value)
				{
					return;
				}
				_replicatedEulerAngles = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("replicatedTransform")] 
		public Transform ReplicatedTransform
		{
			get
			{
				if (_replicatedTransform == null)
				{
					_replicatedTransform = (Transform) CR2WTypeManager.Create("Transform", "replicatedTransform", cr2w, this);
				}
				return _replicatedTransform;
			}
			set
			{
				if (_replicatedTransform == value)
				{
					return;
				}
				_replicatedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("subObject")] 
		public CHandle<Ref_6_ReplicatedVariables_Class> SubObject
		{
			get
			{
				if (_subObject == null)
				{
					_subObject = (CHandle<Ref_6_ReplicatedVariables_Class>) CR2WTypeManager.Create("handle:Ref_6_ReplicatedVariables_Class", "subObject", cr2w, this);
				}
				return _subObject;
			}
			set
			{
				if (_subObject == value)
				{
					return;
				}
				_subObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("Ref_6_ReplicatedVariables_Class")] 
		public wCHandle<Ref_6_ReplicatedVariables_Class> Ref_6_ReplicatedVariables_Class
		{
			get
			{
				if (_ref_6_ReplicatedVariables_Class == null)
				{
					_ref_6_ReplicatedVariables_Class = (wCHandle<Ref_6_ReplicatedVariables_Class>) CR2WTypeManager.Create("whandle:Ref_6_ReplicatedVariables_Class", "Ref_6_ReplicatedVariables_Class", cr2w, this);
				}
				return _ref_6_ReplicatedVariables_Class;
			}
			set
			{
				if (_ref_6_ReplicatedVariables_Class == value)
				{
					return;
				}
				_ref_6_ReplicatedVariables_Class = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("dynArrayOfStructs")] 
		public CArray<Ref_6_ReplicatedVariables_SubStructure> DynArrayOfStructs
		{
			get
			{
				if (_dynArrayOfStructs == null)
				{
					_dynArrayOfStructs = (CArray<Ref_6_ReplicatedVariables_SubStructure>) CR2WTypeManager.Create("array:Ref_6_ReplicatedVariables_SubStructure", "dynArrayOfStructs", cr2w, this);
				}
				return _dynArrayOfStructs;
			}
			set
			{
				if (_dynArrayOfStructs == value)
				{
					return;
				}
				_dynArrayOfStructs = value;
				PropertySet(this);
			}
		}

		public Ref_6_ReplicatedVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
