using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkFastTravelLoadingControllerSupervisor : gameuiWidgetGameController
	{
		private CResourceReference<worldEffect> _glitchEffect;

		[Ordinal(2)] 
		[RED("glitchEffect")] 
		public CResourceReference<worldEffect> GlitchEffect
		{
			get => GetProperty(ref _glitchEffect);
			set => SetProperty(ref _glitchEffect, value);
		}
	}
}
