using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Ref_6_ReplicatedVariables : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("u8")] 
		public CUInt8 U8
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("u16")] 
		public CUInt16 U16
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("u32")] 
		public CUInt32 U32
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("u64")] 
		public CUInt64 U64
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("i8")] 
		public CInt8 I8
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		[Ordinal(5)] 
		[RED("i16")] 
		public CInt16 I16
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(6)] 
		[RED("i32")] 
		public CInt32 I32
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("i64")] 
		public CInt64 I64
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(8)] 
		[RED("aByte")] 
		public CUInt8 AByte
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(9)] 
		[RED("aInt")] 
		public CInt32 AInt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("f")] 
		public CFloat F
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("d")] 
		public CDouble D
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(12)] 
		[RED("aliasedF")] 
		public CFloat AliasedF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("aliasedD")] 
		public CDouble AliasedD
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(14)] 
		[RED("b")] 
		public CBool B
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("str")] 
		public CString Str
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(16)] 
		[RED("aliasedStr")] 
		public CString AliasedStr
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(17)] 
		[RED("cName")] 
		public CName CName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("aliasedCName")] 
		public CName AliasedCName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("subStruct")] 
		public Ref_6_ReplicatedVariables_SubStructure SubStruct
		{
			get => GetPropertyValue<Ref_6_ReplicatedVariables_SubStructure>();
			set => SetPropertyValue<Ref_6_ReplicatedVariables_SubStructure>(value);
		}

		[Ordinal(20)] 
		[RED("replicatedVector4")] 
		public Vector4 ReplicatedVector4
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(21)] 
		[RED("replicatedQuaternion")] 
		public Quaternion ReplicatedQuaternion
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(22)] 
		[RED("replicatedEulerAngles")] 
		public EulerAngles ReplicatedEulerAngles
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(23)] 
		[RED("replicatedTransform")] 
		public Transform ReplicatedTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(24)] 
		[RED("subObject")] 
		public CHandle<Ref_6_ReplicatedVariables_Class> SubObject
		{
			get => GetPropertyValue<CHandle<Ref_6_ReplicatedVariables_Class>>();
			set => SetPropertyValue<CHandle<Ref_6_ReplicatedVariables_Class>>(value);
		}

		[Ordinal(25)] 
		[RED("Ref_6_ReplicatedVariables_Class")] 
		public CWeakHandle<Ref_6_ReplicatedVariables_Class> Ref_6_ReplicatedVariables_Class
		{
			get => GetPropertyValue<CWeakHandle<Ref_6_ReplicatedVariables_Class>>();
			set => SetPropertyValue<CWeakHandle<Ref_6_ReplicatedVariables_Class>>(value);
		}

		[Ordinal(26)] 
		[RED("dynArrayOfStructs")] 
		public CArray<Ref_6_ReplicatedVariables_SubStructure> DynArrayOfStructs
		{
			get => GetPropertyValue<CArray<Ref_6_ReplicatedVariables_SubStructure>>();
			set => SetPropertyValue<CArray<Ref_6_ReplicatedVariables_SubStructure>>(value);
		}

		public Ref_6_ReplicatedVariables()
		{
			D = 0.000000;
			AliasedD = 0.000000;
			SubStruct = new Ref_6_ReplicatedVariables_SubStructure();
			ReplicatedVector4 = new Vector4();
			ReplicatedQuaternion = new Quaternion();
			ReplicatedEulerAngles = new EulerAngles();
			ReplicatedTransform = new Transform();
			DynArrayOfStructs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
