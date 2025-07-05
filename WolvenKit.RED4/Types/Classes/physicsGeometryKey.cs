using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsGeometryKey : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pe")] 
		public CUInt8 Pe
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("ta", 12)] 
		public CArrayFixedSize<CUInt8> Ta
		{
			get => GetPropertyValue<CArrayFixedSize<CUInt8>>();
			set => SetPropertyValue<CArrayFixedSize<CUInt8>>(value);
		}

		public physicsGeometryKey()
		{
			Pe = 6;
			Ta = new(12);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
