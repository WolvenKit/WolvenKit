using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDestructionPSData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gridValues", 30)] 
		public CArrayFixedSize<CFloat> GridValues
		{
			get => GetPropertyValue<CArrayFixedSize<CFloat>>();
			set => SetPropertyValue<CArrayFixedSize<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("brokenGlass")] 
		public CUInt32 BrokenGlass
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("brokenLights")] 
		public CUInt32 BrokenLights
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("flatTire")] 
		public CUInt8 FlatTire
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("windshieldShattered")] 
		public CBool WindshieldShattered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("windshieldPoints")] 
		public CArray<Vector3> WindshieldPoints
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(6)] 
		[RED("detachedParts")] 
		public CArray<CName> DetachedParts
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public vehicleDestructionPSData()
		{
			GridValues = new(30);
			WindshieldPoints = new();
			DetachedParts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
