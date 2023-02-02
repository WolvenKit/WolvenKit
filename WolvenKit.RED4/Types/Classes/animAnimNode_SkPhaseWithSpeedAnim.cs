using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(31)] 
		[RED("speedLink")] 
		public animFloatLink SpeedLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SkPhaseWithSpeedAnim()
		{
			SpeedLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
