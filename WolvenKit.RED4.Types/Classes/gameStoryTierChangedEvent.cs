using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
