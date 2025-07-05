using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeathEvents : HighLevelTransition
	{
		[Ordinal(0)] 
		[RED("isDyingEffectPlaying")] 
		public CBool IsDyingEffectPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeathEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
