using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestItemController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("QuestStatus")] 
		public inkTextWidgetReference QuestStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("QuestIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("TrackedIcon")] 
		public inkImageWidgetReference TrackedIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("NewIcon")] 
		public inkImageWidgetReference NewIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("StyleRoot")] 
		public inkWidgetReference StyleRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("ToTrack")] 
		public CWeakHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get => GetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		[Ordinal(23)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get => GetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		[Ordinal(26)] 
		[RED("QuestData")] 
		public CHandle<QuestDataWrapper> QuestData
		{
			get => GetPropertyValue<CHandle<QuestDataWrapper>>();
			set => SetPropertyValue<CHandle<QuestDataWrapper>>(value);
		}

		public QuestItemController()
		{
			QuestTitle = new();
			QuestStatus = new();
			QuestIcon = new();
			TrackedIcon = new();
			NewIcon = new();
			FrameBackground_On = new();
			FrameBackground_Off = new();
			FrameFluff_On = new();
			FrameFluff_Off = new();
			Folder_On = new();
			Folder_Off = new();
			StyleRoot = new();
			DefaultStateName = "Default";
			MarkedStateName = "Marked";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
