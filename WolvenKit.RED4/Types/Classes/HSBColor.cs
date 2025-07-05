using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HSBColor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Hue")] 
		public CFloat Hue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("Saturation")] 
		public CFloat Saturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("Brightness")] 
		public CFloat Brightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HSBColor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
