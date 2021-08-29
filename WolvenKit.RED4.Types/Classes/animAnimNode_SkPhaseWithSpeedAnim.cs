using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _speedLink;

		[Ordinal(31)] 
		[RED("speedLink")] 
		public animFloatLink SpeedLink
		{
			get => GetProperty(ref _speedLink);
			set => SetProperty(ref _speedLink, value);
		}
	}
}
