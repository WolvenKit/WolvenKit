using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entStaticOrientationProvider : entIOrientationProvider
	{
		[Ordinal(0)] 
		[RED("staticOrientation")] 
		public Quaternion StaticOrientation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public entStaticOrientationProvider()
		{
			StaticOrientation = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
