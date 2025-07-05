using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStoryTierChangedEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("newTier")] 
		public CEnum<gameStoryTier> NewTier
		{
			get => GetPropertyValue<CEnum<gameStoryTier>>();
			set => SetPropertyValue<CEnum<gameStoryTier>>(value);
		}

		public gameStoryTierChangedEvent()
		{
			Name = "StoryTierChanged";
			NewTier = Enums.gameStoryTier.Cinematic;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
