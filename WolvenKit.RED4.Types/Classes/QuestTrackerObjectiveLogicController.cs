using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestTrackerObjectiveLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _objectiveTitle;
		private inkWidgetReference _trackingIcon;
		private inkWidgetReference _trackingFrame;
		private CWeakHandle<gameJournalQuestObjective> _objectiveEntry;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _introAnimProxy;
		private inkanimPlaybackOptions _animOptions;
		private CBool _readyToRemove;

		[Ordinal(1)] 
		[RED("objectiveTitle")] 
		public inkTextWidgetReference ObjectiveTitle
		{
			get => GetProperty(ref _objectiveTitle);
			set => SetProperty(ref _objectiveTitle, value);
		}

		[Ordinal(2)] 
		[RED("trackingIcon")] 
		public inkWidgetReference TrackingIcon
		{
			get => GetProperty(ref _trackingIcon);
			set => SetProperty(ref _trackingIcon, value);
		}

		[Ordinal(3)] 
		[RED("trackingFrame")] 
		public inkWidgetReference TrackingFrame
		{
			get => GetProperty(ref _trackingFrame);
			set => SetProperty(ref _trackingFrame, value);
		}

		[Ordinal(4)] 
		[RED("objectiveEntry")] 
		public CWeakHandle<gameJournalQuestObjective> ObjectiveEntry
		{
			get => GetProperty(ref _objectiveEntry);
			set => SetProperty(ref _objectiveEntry, value);
		}

		[Ordinal(5)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(6)] 
		[RED("IntroAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(8)] 
		[RED("readyToRemove")] 
		public CBool ReadyToRemove
		{
			get => GetProperty(ref _readyToRemove);
			set => SetProperty(ref _readyToRemove, value);
		}
	}
}
