using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestDisableWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("blockReequipping")] 
		public CBool BlockReequipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestDisableWardrobeSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
