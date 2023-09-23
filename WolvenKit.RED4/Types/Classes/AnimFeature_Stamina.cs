using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Stamina : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("staminaValue")] 
		public CFloat StaminaValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("tiredness")] 
		public CFloat Tiredness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Stamina()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
