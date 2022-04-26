using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CrowdRunningAway : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isRunningAwayFromPlayersCar")] 
		public CBool IsRunningAwayFromPlayersCar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_CrowdRunningAway()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
