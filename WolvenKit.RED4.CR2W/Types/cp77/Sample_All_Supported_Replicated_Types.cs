using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_All_Supported_Replicated_Types : CVariable
	{
		private CBool _bool;
		private CUInt8 _uint8;
		private CInt8 _int8;
		private CUInt16 _uint16;
		private CInt16 _int16;
		private CUInt32 _uint32;
		private CInt32 _int32;
		private CUInt64 _uint64;
		private CInt64 _int64;
		private CFloat _float;
		private CDouble _double;
		private CName _name;
		private CString _string;
		private CEnum<Sample_Replicated_Enum> _enum;
		private Sample_Replicated_Struct _struct;
		private CArray<Sample_Replicated_Struct> _dynamicArray;
		private CStatic<Sample_Replicated_Struct> _staticArray;
		private CHandle<Sample_Replicated_Serializable> _tHandle;

		[Ordinal(0)] 
		[RED("bool")] 
		public CBool Bool
		{
			get
			{
				if (_bool == null)
				{
					_bool = (CBool) CR2WTypeManager.Create("Bool", "bool", cr2w, this);
				}
				return _bool;
			}
			set
			{
				if (_bool == value)
				{
					return;
				}
				_bool = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("uint8")] 
		public CUInt8 Uint8
		{
			get
			{
				if (_uint8 == null)
				{
					_uint8 = (CUInt8) CR2WTypeManager.Create("Uint8", "uint8", cr2w, this);
				}
				return _uint8;
			}
			set
			{
				if (_uint8 == value)
				{
					return;
				}
				_uint8 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("int8")] 
		public CInt8 Int8
		{
			get
			{
				if (_int8 == null)
				{
					_int8 = (CInt8) CR2WTypeManager.Create("Int8", "int8", cr2w, this);
				}
				return _int8;
			}
			set
			{
				if (_int8 == value)
				{
					return;
				}
				_int8 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("uint16")] 
		public CUInt16 Uint16
		{
			get
			{
				if (_uint16 == null)
				{
					_uint16 = (CUInt16) CR2WTypeManager.Create("Uint16", "uint16", cr2w, this);
				}
				return _uint16;
			}
			set
			{
				if (_uint16 == value)
				{
					return;
				}
				_uint16 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("int16")] 
		public CInt16 Int16
		{
			get
			{
				if (_int16 == null)
				{
					_int16 = (CInt16) CR2WTypeManager.Create("Int16", "int16", cr2w, this);
				}
				return _int16;
			}
			set
			{
				if (_int16 == value)
				{
					return;
				}
				_int16 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("uint32")] 
		public CUInt32 Uint32
		{
			get
			{
				if (_uint32 == null)
				{
					_uint32 = (CUInt32) CR2WTypeManager.Create("Uint32", "uint32", cr2w, this);
				}
				return _uint32;
			}
			set
			{
				if (_uint32 == value)
				{
					return;
				}
				_uint32 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("int32")] 
		public CInt32 Int32
		{
			get
			{
				if (_int32 == null)
				{
					_int32 = (CInt32) CR2WTypeManager.Create("Int32", "int32", cr2w, this);
				}
				return _int32;
			}
			set
			{
				if (_int32 == value)
				{
					return;
				}
				_int32 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("uint64")] 
		public CUInt64 Uint64
		{
			get
			{
				if (_uint64 == null)
				{
					_uint64 = (CUInt64) CR2WTypeManager.Create("Uint64", "uint64", cr2w, this);
				}
				return _uint64;
			}
			set
			{
				if (_uint64 == value)
				{
					return;
				}
				_uint64 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("int64")] 
		public CInt64 Int64
		{
			get
			{
				if (_int64 == null)
				{
					_int64 = (CInt64) CR2WTypeManager.Create("Int64", "int64", cr2w, this);
				}
				return _int64;
			}
			set
			{
				if (_int64 == value)
				{
					return;
				}
				_int64 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("float")] 
		public CFloat Float
		{
			get
			{
				if (_float == null)
				{
					_float = (CFloat) CR2WTypeManager.Create("Float", "float", cr2w, this);
				}
				return _float;
			}
			set
			{
				if (_float == value)
				{
					return;
				}
				_float = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("double")] 
		public CDouble Double
		{
			get
			{
				if (_double == null)
				{
					_double = (CDouble) CR2WTypeManager.Create("Double", "double", cr2w, this);
				}
				return _double;
			}
			set
			{
				if (_double == value)
				{
					return;
				}
				_double = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("string")] 
		public CString String
		{
			get
			{
				if (_string == null)
				{
					_string = (CString) CR2WTypeManager.Create("String", "string", cr2w, this);
				}
				return _string;
			}
			set
			{
				if (_string == value)
				{
					return;
				}
				_string = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("enum")] 
		public CEnum<Sample_Replicated_Enum> Enum
		{
			get
			{
				if (_enum == null)
				{
					_enum = (CEnum<Sample_Replicated_Enum>) CR2WTypeManager.Create("Sample_Replicated_Enum", "enum", cr2w, this);
				}
				return _enum;
			}
			set
			{
				if (_enum == value)
				{
					return;
				}
				_enum = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("struct")] 
		public Sample_Replicated_Struct Struct
		{
			get
			{
				if (_struct == null)
				{
					_struct = (Sample_Replicated_Struct) CR2WTypeManager.Create("Sample_Replicated_Struct", "struct", cr2w, this);
				}
				return _struct;
			}
			set
			{
				if (_struct == value)
				{
					return;
				}
				_struct = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dynamicArray")] 
		public CArray<Sample_Replicated_Struct> DynamicArray
		{
			get
			{
				if (_dynamicArray == null)
				{
					_dynamicArray = (CArray<Sample_Replicated_Struct>) CR2WTypeManager.Create("array:Sample_Replicated_Struct", "dynamicArray", cr2w, this);
				}
				return _dynamicArray;
			}
			set
			{
				if (_dynamicArray == value)
				{
					return;
				}
				_dynamicArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("staticArray", 10)] 
		public CStatic<Sample_Replicated_Struct> StaticArray
		{
			get
			{
				if (_staticArray == null)
				{
					_staticArray = (CStatic<Sample_Replicated_Struct>) CR2WTypeManager.Create("static:10,Sample_Replicated_Struct", "staticArray", cr2w, this);
				}
				return _staticArray;
			}
			set
			{
				if (_staticArray == value)
				{
					return;
				}
				_staticArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("THandle")] 
		public CHandle<Sample_Replicated_Serializable> THandle
		{
			get
			{
				if (_tHandle == null)
				{
					_tHandle = (CHandle<Sample_Replicated_Serializable>) CR2WTypeManager.Create("handle:Sample_Replicated_Serializable", "THandle", cr2w, this);
				}
				return _tHandle;
			}
			set
			{
				if (_tHandle == value)
				{
					return;
				}
				_tHandle = value;
				PropertySet(this);
			}
		}

		public Sample_All_Supported_Replicated_Types(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
