using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MuteArmDurationModifier : gameEffectDurationModifier_Scripted
	{
		private CFloat _initialDuration;

		[Ordinal(0)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get => GetProperty(ref _initialDuration);
			set => SetProperty(ref _initialDuration, value);
		}
	}
}
