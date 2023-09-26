using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestItemController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("QuestStatus")] 
		public inkTextWidgetReference QuestStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("QuestIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("TrackedIcon")] 
		public inkImageWidgetReference TrackedIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("NewIcon")] 
		public inkImageWidgetReference NewIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("StyleRoot")] 
		public inkWidgetReference StyleRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("ToTrack")] 
		public CWeakHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get => GetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		[Ordinal(26)] 
		[RED("DefaultStateName")] 
		public CName DefaultStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get => GetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		[Ordinal(29)] 
		[RED("QuestData")] 
		public CHandle<QuestDataWrapper> QuestData
		{
			get => GetPropertyValue<CHandle<QuestDataWrapper>>();
			set => SetPropertyValue<CHandle<QuestDataWrapper>>(value);
		}

		public QuestItemController()
		{
			QuestTitle = new inkTextWidgetReference();
			QuestStatus = new inkTextWidgetReference();
			QuestIcon = new inkImageWidgetReference();
			TrackedIcon = new inkImageWidgetReference();
			NewIcon = new inkImageWidgetReference();
			FrameBackground_On = new inkImageWidgetReference();
			FrameBackground_Off = new inkImageWidgetReference();
			FrameFluff_On = new inkImageWidgetReference();
			FrameFluff_Off = new inkImageWidgetReference();
			Folder_On = new inkImageWidgetReference();
			Folder_Off = new inkImageWidgetReference();
			StyleRoot = new inkWidgetReference();
			DefaultStateName = "Default";
			MarkedStateName = "Marked";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
