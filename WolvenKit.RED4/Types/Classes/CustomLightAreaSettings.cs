using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CustomLightAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("characterLocalLightRoughnesBias")] 
		public CLegacySingleChannelCurve<CFloat> CharacterLocalLightRoughnesBias
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public CustomLightAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
