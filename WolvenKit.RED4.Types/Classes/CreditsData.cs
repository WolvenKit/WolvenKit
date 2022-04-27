using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CreditsData : inkUserData
	{
		[Ordinal(0)] 
		[RED("isFinalBoards")] 
		public CBool IsFinalBoards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("showRewardPrompt")] 
		public CBool ShowRewardPrompt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CreditsData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
