using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomLightAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<CFloat> _characterLocalLightRoughnesBias;

		[Ordinal(2)] 
		[RED("characterLocalLightRoughnesBias")] 
		public CLegacySingleChannelCurve<CFloat> CharacterLocalLightRoughnesBias
		{
			get => GetProperty(ref _characterLocalLightRoughnesBias);
			set => SetProperty(ref _characterLocalLightRoughnesBias, value);
		}
	}
}
