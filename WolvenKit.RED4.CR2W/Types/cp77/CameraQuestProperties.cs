using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraQuestProperties : CVariable
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

		public CameraQuestProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
