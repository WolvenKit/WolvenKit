using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] 
		[RED("isFinalRemoval")] 
		public CBool IsFinalRemoval
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameeventsRemoveStatusEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
