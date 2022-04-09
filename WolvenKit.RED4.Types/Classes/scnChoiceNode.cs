using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNode : scnSceneGraphNode
	{
		[Ordinal(3)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("localizedDisplayNameOverride")] 
		public LocalizationString LocalizedDisplayNameOverride
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(5)] 
		[RED("options")] 
		public CArray<scnChoiceNodeOption> Options
		{
			get => GetPropertyValue<CArray<scnChoiceNodeOption>>();
			set => SetPropertyValue<CArray<scnChoiceNodeOption>>(value);
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CEnum<scnChoiceNodeNsOperationMode> Mode
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsOperationMode>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsOperationMode>>(value);
		}

		[Ordinal(7)] 
		[RED("persistentLineEvents")] 
		public CArray<scnSceneEventId> PersistentLineEvents
		{
			get => GetPropertyValue<CArray<scnSceneEventId>>();
			set => SetPropertyValue<CArray<scnSceneEventId>>(value);
		}

		[Ordinal(8)] 
		[RED("customPersistentLine")] 
		public scnscreenplayItemId CustomPersistentLine
		{
			get => GetPropertyValue<scnscreenplayItemId>();
			set => SetPropertyValue<scnscreenplayItemId>(value);
		}

		[Ordinal(9)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get => GetPropertyValue<CHandle<scnChoiceNodeNsTimedParams>>();
			set => SetPropertyValue<CHandle<scnChoiceNodeNsTimedParams>>(value);
		}

		[Ordinal(10)] 
		[RED("reminderParams")] 
		public CHandle<scnChoiceNodeNsActorReminderParams> ReminderParams
		{
			get => GetPropertyValue<CHandle<scnChoiceNodeNsActorReminderParams>>();
			set => SetPropertyValue<CHandle<scnChoiceNodeNsActorReminderParams>>(value);
		}

		[Ordinal(11)] 
		[RED("shapeParams")] 
		public CHandle<scnInteractionShapeParams> ShapeParams
		{
			get => GetPropertyValue<CHandle<scnInteractionShapeParams>>();
			set => SetPropertyValue<CHandle<scnInteractionShapeParams>>(value);
		}

		[Ordinal(12)] 
		[RED("lookAtParams")] 
		public CHandle<scnChoiceNodeNsLookAtParams> LookAtParams
		{
			get => GetPropertyValue<CHandle<scnChoiceNodeNsLookAtParams>>();
			set => SetPropertyValue<CHandle<scnChoiceNodeNsLookAtParams>>(value);
		}

		[Ordinal(13)] 
		[RED("forceAttachToScreenCondition")] 
		public CHandle<questIBaseCondition> ForceAttachToScreenCondition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(14)] 
		[RED("choiceGroup")] 
		public CName ChoiceGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("cpoHoldInputActionSection")] 
		public CBool CpoHoldInputActionSection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("ataParams")] 
		public scnChoiceNodeNsAttachToActorParams AtaParams
		{
			get => GetPropertyValue<scnChoiceNodeNsAttachToActorParams>();
			set => SetPropertyValue<scnChoiceNodeNsAttachToActorParams>(value);
		}

		[Ordinal(17)] 
		[RED("atpParams")] 
		public scnChoiceNodeNsAttachToPropParams AtpParams
		{
			get => GetPropertyValue<scnChoiceNodeNsAttachToPropParams>();
			set => SetPropertyValue<scnChoiceNodeNsAttachToPropParams>(value);
		}

		[Ordinal(18)] 
		[RED("atgoParams")] 
		public scnChoiceNodeNsAttachToGameObjectParams AtgoParams
		{
			get => GetPropertyValue<scnChoiceNodeNsAttachToGameObjectParams>();
			set => SetPropertyValue<scnChoiceNodeNsAttachToGameObjectParams>(value);
		}

		[Ordinal(19)] 
		[RED("atsParams")] 
		public scnChoiceNodeNsAttachToScreenParams AtsParams
		{
			get => GetPropertyValue<scnChoiceNodeNsAttachToScreenParams>();
			set => SetPropertyValue<scnChoiceNodeNsAttachToScreenParams>(value);
		}

		[Ordinal(20)] 
		[RED("atwParams")] 
		public scnChoiceNodeNsAttachToWorldParams AtwParams
		{
			get => GetPropertyValue<scnChoiceNodeNsAttachToWorldParams>();
			set => SetPropertyValue<scnChoiceNodeNsAttachToWorldParams>(value);
		}

		[Ordinal(21)] 
		[RED("choicePriority")] 
		public CUInt8 ChoicePriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(22)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(23)] 
		[RED("mappinParams")] 
		public CHandle<scnChoiceNodeNsMappinParams> MappinParams
		{
			get => GetPropertyValue<CHandle<scnChoiceNodeNsMappinParams>>();
			set => SetPropertyValue<CHandle<scnChoiceNodeNsMappinParams>>(value);
		}

		[Ordinal(24)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get => GetPropertyValue<CEnum<scnInterruptCapability>>();
			set => SetPropertyValue<CEnum<scnInterruptCapability>>(value);
		}

		[Ordinal(25)] 
		[RED("interruptionSpeakerOverride")] 
		public scnActorId InterruptionSpeakerOverride
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(26)] 
		[RED("choiceFlags")] 
		public CBitField<scnChoiceNodeNsChoiceNodeBitFlags> ChoiceFlags
		{
			get => GetPropertyValue<CBitField<scnChoiceNodeNsChoiceNodeBitFlags>>();
			set => SetPropertyValue<CBitField<scnChoiceNodeNsChoiceNodeBitFlags>>(value);
		}

		[Ordinal(27)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("timedSectionCondition")] 
		public CHandle<scnTimedCondition> TimedSectionCondition
		{
			get => GetPropertyValue<CHandle<scnTimedCondition>>();
			set => SetPropertyValue<CHandle<scnTimedCondition>>(value);
		}

		[Ordinal(29)] 
		[RED("reminderCondition")] 
		public CHandle<scnReminderCondition> ReminderCondition
		{
			get => GetPropertyValue<CHandle<scnReminderCondition>>();
			set => SetPropertyValue<CHandle<scnReminderCondition>>(value);
		}

		public scnChoiceNode()
		{
			NodeId = new() { Id = 4294967295 };
			OutputSockets = new();
			LocalizedDisplayNameOverride = new() { Unk1 = 0, Value = "" };
			Options = new();
			Mode = Enums.scnChoiceNodeNsOperationMode.attachToScreen;
			PersistentLineEvents = new();
			CustomPersistentLine = new() { Id = 4294967040 };
			AtaParams = new() { ActorId = new() { Id = 4294967295 } };
			AtpParams = new() { PropId = new() { Id = 4294967295 }, VisualizerStyle = Enums.scnChoiceNodeNsVisualizerStyle.inWorld };
			AtgoParams = new() { VisualizerStyle = Enums.scnChoiceNodeNsVisualizerStyle.inWorld };
			AtsParams = new();
			AtwParams = new() { EntityPosition = new(), EntityOrientation = new() { R = 1.000000F } };
			InterruptCapability = Enums.scnInterruptCapability.Interruptable;
			InterruptionSpeakerOverride = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
