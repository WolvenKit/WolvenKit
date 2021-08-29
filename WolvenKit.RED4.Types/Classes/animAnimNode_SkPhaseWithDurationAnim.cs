using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _durationLink;

		[Ordinal(31)] 
		[RED("durationLink")] 
		public animFloatLink DurationLink
		{
			get => GetProperty(ref _durationLink);
			set => SetProperty(ref _durationLink, value);
		}
	}
}
