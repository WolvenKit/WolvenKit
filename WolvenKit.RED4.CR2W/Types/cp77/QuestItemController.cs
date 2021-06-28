using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestItemController : inkButtonController
	{
		private inkTextWidgetReference _questTitle;
		private inkTextWidgetReference _questStatus;
		private inkImageWidgetReference _questIcon;
		private inkImageWidgetReference _trackedIcon;
		private inkImageWidgetReference _newIcon;
		private inkImageWidgetReference _frameBackground_On;
		private inkImageWidgetReference _frameBackground_Off;
		private inkImageWidgetReference _frameFluff_On;
		private inkImageWidgetReference _frameFluff_Off;
		private inkImageWidgetReference _folder_On;
		private inkImageWidgetReference _folder_Off;
		private inkWidgetReference _styleRoot;
		private wCHandle<ABaseQuestObjectiveWrapper> _toTrack;
		private CName _defaultStateName;
		private CName _markedStateName;
		private CHandle<ABaseQuestObjectiveWrapper> _questObjectiveData;
		private CHandle<QuestDataWrapper> _questData;

		[Ordinal(10)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(11)] 
		[RED("QuestStatus")] 
		public inkTextWidgetReference QuestStatus
		{
			get => GetProperty(ref _questStatus);
			set => SetProperty(ref _questStatus, value);
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
		[RED("NewIcon")] 
		public inkImageWidgetReference NewIcon
		{
			get => GetProperty(ref _newIcon);
			set => SetProperty(ref _newIcon, value);
		}

		[Ordinal(15)] 
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get => GetProperty(ref _frameBackground_On);
			set => SetProperty(ref _frameBackground_On, value);
		}

		[Ordinal(16)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get => GetProperty(ref _frameBackground_Off);
			set => SetProperty(ref _frameBackground_Off, value);
		}

		[Ordinal(17)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get => GetProperty(ref _frameFluff_On);
			set => SetProperty(ref _frameFluff_On, value);
		}

		[Ordinal(18)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get => GetProperty(ref _frameFluff_Off);
			set => SetProperty(ref _frameFluff_Off, value);
		}

		[Ordinal(19)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get => GetProperty(ref _folder_On);
			set => SetProperty(ref _folder_On, value);
		}

		[Ordinal(20)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get => GetProperty(ref _folder_Off);
			set => SetProperty(ref _folder_Off, value);
		}

		[Ordinal(21)] 
		[RED("StyleRoot")] 
		public inkWidgetReference StyleRoot
		{
			get => GetProperty(ref _styleRoot);
			set => SetProperty(ref _styleRoot, value);
		}

		[Ordinal(22)] 
		[RED("ToTrack")] 
		public wCHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get => GetProperty(ref _toTrack);
			set => SetProperty(ref _toTrack, value);
		}

		[Ordinal(23)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get => GetProperty(ref _defaultStateName);
			set => SetProperty(ref _defaultStateName, value);
		}

		[Ordinal(24)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get => GetProperty(ref _markedStateName);
			set => SetProperty(ref _markedStateName, value);
		}

		[Ordinal(25)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get => GetProperty(ref _questObjectiveData);
			set => SetProperty(ref _questObjectiveData, value);
		}

		[Ordinal(26)] 
		[RED("QuestData")] 
		public CHandle<QuestDataWrapper> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		public QuestItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
