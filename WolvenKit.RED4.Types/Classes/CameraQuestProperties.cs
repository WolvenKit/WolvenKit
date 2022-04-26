using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraQuestProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("followedTargetID")] 
		public entEntityID FollowedTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public CameraQuestProperties()
		{
			FollowedTargetID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
