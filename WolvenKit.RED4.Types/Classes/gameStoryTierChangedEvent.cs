using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStoryTierChangedEvent : AIAIEvent
	{
		private CEnum<gameStoryTier> _newTier;

		[Ordinal(2)] 
		[RED("newTier")] 
		public CEnum<gameStoryTier> NewTier
		{
			get => GetProperty(ref _newTier);
			set => SetProperty(ref _newTier, value);
		}
	}
}
