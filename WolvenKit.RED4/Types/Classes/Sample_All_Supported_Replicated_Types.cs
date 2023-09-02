using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Sample_All_Supported_Replicated_Types : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bool")] 
		public CBool Bool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("uint8")] 
		public CUInt8 Uint8
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("int8")] 
		public CInt8 Int8
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(3)] 
		[RED("uint16")] 
		public CUInt16 Uint16
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(4)] 
		[RED("int16")] 
		public CInt16 Int16
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(5)] 
		[RED("uint32")] 
		public CUInt32 Uint32
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("int32")] 
		public CInt32 Int32
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("uint64")] 
		public CUInt64 Uint64
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(8)] 
		[RED("int64")] 
		public CInt64 Int64
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(9)] 
		[RED("float")] 
		public CFloat Float
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("double")] 
		public CDouble Double
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(11)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("string")] 
		public CString String
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("enum")] 
		public CEnum<Sample_Replicated_Enum> Enum
		{
			get => GetPropertyValue<CEnum<Sample_Replicated_Enum>>();
			set => SetPropertyValue<CEnum<Sample_Replicated_Enum>>(value);
		}

		[Ordinal(14)] 
		[RED("struct")] 
		public Sample_Replicated_Struct Struct
		{
			get => GetPropertyValue<Sample_Replicated_Struct>();
			set => SetPropertyValue<Sample_Replicated_Struct>(value);
		}

		[Ordinal(15)] 
		[RED("dynamicArray")] 
		public CArray<Sample_Replicated_Struct> DynamicArray
		{
			get => GetPropertyValue<CArray<Sample_Replicated_Struct>>();
			set => SetPropertyValue<CArray<Sample_Replicated_Struct>>(value);
		}

		[Ordinal(16)] 
		[RED("staticArray", 10)] 
		public CStatic<Sample_Replicated_Struct> StaticArray
		{
			get => GetPropertyValue<CStatic<Sample_Replicated_Struct>>();
			set => SetPropertyValue<CStatic<Sample_Replicated_Struct>>(value);
		}

		[Ordinal(17)] 
		[RED("THandle")] 
		public CHandle<Sample_Replicated_Serializable> THandle
		{
			get => GetPropertyValue<CHandle<Sample_Replicated_Serializable>>();
			set => SetPropertyValue<CHandle<Sample_Replicated_Serializable>>(value);
		}

		public Sample_All_Supported_Replicated_Types()
		{
			Double = 0.000000;
			Struct = new Sample_Replicated_Struct();
			DynamicArray = new();
			StaticArray = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
