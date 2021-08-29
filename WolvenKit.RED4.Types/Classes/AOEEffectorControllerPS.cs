using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AOEEffectorControllerPS : ActivatedDeviceControllerPS
	{
		private CArray<CName> _effectsToPlay;

		[Ordinal(108)] 
		[RED("effectsToPlay")] 
		public CArray<CName> EffectsToPlay
		{
			get => GetProperty(ref _effectsToPlay);
			set => SetProperty(ref _effectsToPlay, value);
		}
	}
}
