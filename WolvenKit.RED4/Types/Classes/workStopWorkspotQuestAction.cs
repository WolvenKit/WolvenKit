using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workStopWorkspotQuestAction : workIWorkspotQuestAction
	{
		[Ordinal(0)] 
		[RED("allowCurrAnimToFinish")] 
		public CBool AllowCurrAnimToFinish
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("exitAnim")] 
		public CName ExitAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workStopWorkspotQuestAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
