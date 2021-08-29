using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraQuestProperties : RedBaseClass
	{
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;
		private CBool _isInFollowMode;
		private entEntityID _followedTargetID;

		[Ordinal(0)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetProperty(ref _factOnFeedReceived);
			set => SetProperty(ref _factOnFeedReceived, value);
		}

		[Ordinal(1)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetProperty(ref _questFactOnDetection);
			set => SetProperty(ref _questFactOnDetection, value);
		}

		[Ordinal(2)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get => GetProperty(ref _isInFollowMode);
			set => SetProperty(ref _isInFollowMode, value);
		}

		[Ordinal(3)] 
		[RED("followedTargetID")] 
		public entEntityID FollowedTargetID
		{
			get => GetProperty(ref _followedTargetID);
			set => SetProperty(ref _followedTargetID, value);
		}
	}
}
