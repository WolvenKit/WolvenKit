using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		private CFloat _timeToLive;

		[Ordinal(0)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetProperty(ref _timeToLive);
			set => SetProperty(ref _timeToLive, value);
		}
	}
}
