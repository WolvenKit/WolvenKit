using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ObjectiveEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("blinkTotalTime")] 
		public CFloat BlinkTotalTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("texturePart_Tracked")] 
		public CName TexturePart_Tracked
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("texturePart_Untracked")] 
		public CName TexturePart_Untracked
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("texturePart_Succeeded")] 
		public CName TexturePart_Succeeded
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("texturePart_Failed")] 
		public CName TexturePart_Failed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("isLargeUpdateWidget")] 
		public CBool IsLargeUpdateWidget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("entryName")] 
		public CWeakHandle<inkTextWidget> EntryName
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("entryOptional")] 
		public CWeakHandle<inkTextWidget> EntryOptional
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("stateIcon")] 
		public CWeakHandle<inkImageWidget> StateIcon
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("trackedIcon")] 
		public CWeakHandle<inkImageWidget> TrackedIcon
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("blinkWidget")] 
		public CWeakHandle<inkWidget> BlinkWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("animBlinkDef")] 
		public CHandle<inkanimDefinition> AnimBlinkDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(15)] 
		[RED("animBlink")] 
		public CHandle<inkanimProxy> AnimBlink
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(16)] 
		[RED("animFadeDef")] 
		public CHandle<inkanimDefinition> AnimFadeDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("animFade")] 
		public CHandle<inkanimProxy> AnimFade
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("entryId")] 
		public CInt32 EntryId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get => GetPropertyValue<CEnum<UIObjectiveEntryType>>();
			set => SetPropertyValue<CEnum<UIObjectiveEntryType>>(value);
		}

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(21)] 
		[RED("parentEntry")] 
		public CWeakHandle<ObjectiveEntryLogicController> ParentEntry
		{
			get => GetPropertyValue<CWeakHandle<ObjectiveEntryLogicController>>();
			set => SetPropertyValue<CWeakHandle<ObjectiveEntryLogicController>>(value);
		}

		[Ordinal(22)] 
		[RED("childCount")] 
		public CInt32 ChildCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("updated")] 
		public CBool Updated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ObjectiveEntryLogicController()
		{
			BlinkInterval = 0.800000F;
			BlinkTotalTime = 5.000000F;
			TexturePart_Tracked = "tracked_left";
			TexturePart_Untracked = "untracked_left";
			TexturePart_Succeeded = "succeeded";
			TexturePart_Failed = "failed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
