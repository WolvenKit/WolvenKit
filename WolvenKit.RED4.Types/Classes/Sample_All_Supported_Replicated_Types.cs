using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_All_Supported_Replicated_Types : RedBaseClass
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
			get => GetProperty(ref _bool);
			set => SetProperty(ref _bool, value);
		}

		[Ordinal(1)] 
		[RED("uint8")] 
		public CUInt8 Uint8
		{
			get => GetProperty(ref _uint8);
			set => SetProperty(ref _uint8, value);
		}

		[Ordinal(2)] 
		[RED("int8")] 
		public CInt8 Int8
		{
			get => GetProperty(ref _int8);
			set => SetProperty(ref _int8, value);
		}

		[Ordinal(3)] 
		[RED("uint16")] 
		public CUInt16 Uint16
		{
			get => GetProperty(ref _uint16);
			set => SetProperty(ref _uint16, value);
		}

		[Ordinal(4)] 
		[RED("int16")] 
		public CInt16 Int16
		{
			get => GetProperty(ref _int16);
			set => SetProperty(ref _int16, value);
		}

		[Ordinal(5)] 
		[RED("uint32")] 
		public CUInt32 Uint32
		{
			get => GetProperty(ref _uint32);
			set => SetProperty(ref _uint32, value);
		}

		[Ordinal(6)] 
		[RED("int32")] 
		public CInt32 Int32
		{
			get => GetProperty(ref _int32);
			set => SetProperty(ref _int32, value);
		}

		[Ordinal(7)] 
		[RED("uint64")] 
		public CUInt64 Uint64
		{
			get => GetProperty(ref _uint64);
			set => SetProperty(ref _uint64, value);
		}

		[Ordinal(8)] 
		[RED("int64")] 
		public CInt64 Int64
		{
			get => GetProperty(ref _int64);
			set => SetProperty(ref _int64, value);
		}

		[Ordinal(9)] 
		[RED("float")] 
		public CFloat Float
		{
			get => GetProperty(ref _float);
			set => SetProperty(ref _float, value);
		}

		[Ordinal(10)] 
		[RED("double")] 
		public CDouble Double
		{
			get => GetProperty(ref _double);
			set => SetProperty(ref _double, value);
		}

		[Ordinal(11)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(12)] 
		[RED("string")] 
		public CString String
		{
			get => GetProperty(ref _string);
			set => SetProperty(ref _string, value);
		}

		[Ordinal(13)] 
		[RED("enum")] 
		public CEnum<Sample_Replicated_Enum> Enum
		{
			get => GetProperty(ref _enum);
			set => SetProperty(ref _enum, value);
		}

		[Ordinal(14)] 
		[RED("struct")] 
		public Sample_Replicated_Struct Struct
		{
			get => GetProperty(ref _struct);
			set => SetProperty(ref _struct, value);
		}

		[Ordinal(15)] 
		[RED("dynamicArray")] 
		public CArray<Sample_Replicated_Struct> DynamicArray
		{
			get => GetProperty(ref _dynamicArray);
			set => SetProperty(ref _dynamicArray, value);
		}

		[Ordinal(16)] 
		[RED("staticArray", 10)] 
		public CStatic<Sample_Replicated_Struct> StaticArray
		{
			get => GetProperty(ref _staticArray);
			set => SetProperty(ref _staticArray, value);
		}

		[Ordinal(17)] 
		[RED("THandle")] 
		public CHandle<Sample_Replicated_Serializable> THandle
		{
			get => GetProperty(ref _tHandle);
			set => SetProperty(ref _tHandle, value);
		}
	}
}
