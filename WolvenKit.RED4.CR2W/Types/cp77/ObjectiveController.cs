using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectiveController : inkButtonController
	{
		private inkTextWidgetReference _objectiveLabel;
		private inkTextWidgetReference _objectiveStatus;
		private inkImageWidgetReference _questIcon;
		private inkImageWidgetReference _trackedIcon;
		private inkImageWidgetReference _frameBackground_On;
		private inkImageWidgetReference _frameBackground_Off;
		private inkImageWidgetReference _frameFluff_On;
		private inkImageWidgetReference _frameFluff_Off;
		private inkImageWidgetReference _folder_On;
		private inkImageWidgetReference _folder_Off;
		private CHandle<ABaseQuestObjectiveWrapper> _questObjectiveData;
		private wCHandle<ABaseQuestObjectiveWrapper> _toTrack;

		[Ordinal(10)] 
		[RED("ObjectiveLabel")] 
		public inkTextWidgetReference ObjectiveLabel
		{
			get => GetProperty(ref _objectiveLabel);
			set => SetProperty(ref _objectiveLabel, value);
		}

		[Ordinal(11)] 
		[RED("ObjectiveStatus")] 
		public inkTextWidgetReference ObjectiveStatus
		{
			get => GetProperty(ref _objectiveStatus);
			set => SetProperty(ref _objectiveStatus, value);
		}

		[Ordinal(12)] 
		[RED("QuestIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get => GetProperty(ref _questIcon);
			set => SetProperty(ref _questIcon, value);
		}

		[Ordinal(13)] 
		[RED("TrackedIcon")] 
		public inkImageWidgetReference TrackedIcon
		{
			get => GetProperty(ref _trackedIcon);
			set => SetProperty(ref _trackedIcon, value);
		}

		[Ordinal(14)] 
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get => GetProperty(ref _frameBackground_On);
			set => SetProperty(ref _frameBackground_On, value);
		}

		[Ordinal(15)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get => GetProperty(ref _frameBackground_Off);
			set => SetProperty(ref _frameBackground_Off, value);
		}

		[Ordinal(16)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get => GetProperty(ref _frameFluff_On);
			set => SetProperty(ref _frameFluff_On, value);
		}

		[Ordinal(17)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get => GetProperty(ref _frameFluff_Off);
			set => SetProperty(ref _frameFluff_Off, value);
		}

		[Ordinal(18)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get => GetProperty(ref _folder_On);
			set => SetProperty(ref _folder_On, value);
		}

		[Ordinal(19)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get => GetProperty(ref _folder_Off);
			set => SetProperty(ref _folder_Off, value);
		}

		[Ordinal(20)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get => GetProperty(ref _questObjectiveData);
			set => SetProperty(ref _questObjectiveData, value);
		}

		[Ordinal(21)] 
		[RED("ToTrack")] 
		public wCHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get => GetProperty(ref _toTrack);
			set => SetProperty(ref _toTrack, value);
		}

		public ObjectiveController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
