using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectDuration_PredefinedTimeout : gameEffectDurationModifier
	{
		[Ordinal(0)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
