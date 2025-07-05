using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimInputSetterAnimFeature : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CHandle<animAnimFeature> Value
		{
			get => GetPropertyValue<CHandle<animAnimFeature>>();
			set => SetPropertyValue<CHandle<animAnimFeature>>(value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entAnimInputSetterAnimFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
