using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	[RED("Color")]
	public partial class CColor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Red")] 
		public CUInt8 Red
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CUInt8 Green
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CUInt8 Blue
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("Alpha")] 
		public CUInt8 Alpha
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public CColor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
