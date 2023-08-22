using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ObjectiveController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("ObjectiveLabel")] 
		public inkTextWidgetReference ObjectiveLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("ObjectiveStatus")] 
		public inkTextWidgetReference ObjectiveStatus
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
		[RED("FrameBackground_On")] 
		public inkImageWidgetReference FrameBackground_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("FrameBackground_Off")] 
		public inkImageWidgetReference FrameBackground_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("FrameFluff_On")] 
		public inkImageWidgetReference FrameFluff_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("FrameFluff_Off")] 
		public inkImageWidgetReference FrameFluff_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("Folder_On")] 
		public inkImageWidgetReference Folder_On
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("Folder_Off")] 
		public inkImageWidgetReference Folder_Off
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("QuestObjectiveData")] 
		public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData
		{
			get => GetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		[Ordinal(21)] 
		[RED("ToTrack")] 
		public CWeakHandle<ABaseQuestObjectiveWrapper> ToTrack
		{
			get => GetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>();
			set => SetPropertyValue<CWeakHandle<ABaseQuestObjectiveWrapper>>(value);
		}

		public ObjectiveController()
		{
			ObjectiveLabel = new inkTextWidgetReference();
			ObjectiveStatus = new inkTextWidgetReference();
			QuestIcon = new inkImageWidgetReference();
			TrackedIcon = new inkImageWidgetReference();
			FrameBackground_On = new inkImageWidgetReference();
			FrameBackground_Off = new inkImageWidgetReference();
			FrameFluff_On = new inkImageWidgetReference();
			FrameFluff_Off = new inkImageWidgetReference();
			Folder_On = new inkImageWidgetReference();
			Folder_Off = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
