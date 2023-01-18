using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(31)] 
		[RED("durationLink")] 
		public animFloatLink DurationLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SkPhaseWithDurationAnim()
		{
			DurationLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
