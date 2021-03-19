using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNode : scnSceneGraphNode
	{
		private CString _displayNameOverride;
		private LocalizationString _localizedDisplayNameOverride;
		private CArray<scnChoiceNodeOption> _options;
		private CEnum<scnChoiceNodeNsOperationMode> _mode;
		private CArray<scnSceneEventId> _persistentLineEvents;
		private scnscreenplayItemId _customPersistentLine;
		private CHandle<scnChoiceNodeNsTimedParams> _timedParams;
		private CHandle<scnChoiceNodeNsActorReminderParams> _reminderParams;
		private CHandle<scnInteractionShapeParams> _shapeParams;
		private CHandle<scnChoiceNodeNsLookAtParams> _lookAtParams;
		private CHandle<questIBaseCondition> _forceAttachToScreenCondition;
		private CName _choiceGroup;
		private CBool _cpoHoldInputActionSection;
		private scnChoiceNodeNsAttachToActorParams _ataParams;
		private scnChoiceNodeNsAttachToPropParams _atpParams;
		private scnChoiceNodeNsAttachToGameObjectParams _atgoParams;
		private scnChoiceNodeNsAttachToScreenParams _atsParams;
		private scnChoiceNodeNsAttachToWorldParams _atwParams;
		private CUInt8 _choicePriority;
		private CUInt8 _hubPriority;
		private CHandle<scnChoiceNodeNsMappinParams> _mappinParams;
		private CEnum<scnInterruptCapability> _interruptCapability;
		private scnActorId _interruptionSpeakerOverride;
		private CEnum<scnChoiceNodeNsChoiceNodeBitFlags> _choiceFlags;
		private CBool _alwaysUseBrainGender;
		private CHandle<scnTimedCondition> _timedSectionCondition;
		private CHandle<scnReminderCondition> _reminderCondition;

		[Ordinal(3)] 
		[RED("displayNameOverride")] 
		public CString DisplayNameOverride
		{
			get => GetProperty(ref _displayNameOverride);
			set => SetProperty(ref _displayNameOverride, value);
		}

		[Ordinal(4)] 
		[RED("localizedDisplayNameOverride")] 
		public LocalizationString LocalizedDisplayNameOverride
		{
			get => GetProperty(ref _localizedDisplayNameOverride);
			set => SetProperty(ref _localizedDisplayNameOverride, value);
		}

		[Ordinal(5)] 
		[RED("options")] 
		public CArray<scnChoiceNodeOption> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CEnum<scnChoiceNodeNsOperationMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(7)] 
		[RED("persistentLineEvents")] 
		public CArray<scnSceneEventId> PersistentLineEvents
		{
			get => GetProperty(ref _persistentLineEvents);
			set => SetProperty(ref _persistentLineEvents, value);
		}

		[Ordinal(8)] 
		[RED("customPersistentLine")] 
		public scnscreenplayItemId CustomPersistentLine
		{
			get => GetProperty(ref _customPersistentLine);
			set => SetProperty(ref _customPersistentLine, value);
		}

		[Ordinal(9)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get => GetProperty(ref _timedParams);
			set => SetProperty(ref _timedParams, value);
		}

		[Ordinal(10)] 
		[RED("reminderParams")] 
		public CHandle<scnChoiceNodeNsActorReminderParams> ReminderParams
		{
			get => GetProperty(ref _reminderParams);
			set => SetProperty(ref _reminderParams, value);
		}

		[Ordinal(11)] 
		[RED("shapeParams")] 
		public CHandle<scnInteractionShapeParams> ShapeParams
		{
			get => GetProperty(ref _shapeParams);
			set => SetProperty(ref _shapeParams, value);
		}

		[Ordinal(12)] 
		[RED("lookAtParams")] 
		public CHandle<scnChoiceNodeNsLookAtParams> LookAtParams
		{
			get => GetProperty(ref _lookAtParams);
			set => SetProperty(ref _lookAtParams, value);
		}

		[Ordinal(13)] 
		[RED("forceAttachToScreenCondition")] 
		public CHandle<questIBaseCondition> ForceAttachToScreenCondition
		{
			get => GetProperty(ref _forceAttachToScreenCondition);
			set => SetProperty(ref _forceAttachToScreenCondition, value);
		}

		[Ordinal(14)] 
		[RED("choiceGroup")] 
		public CName ChoiceGroup
		{
			get => GetProperty(ref _choiceGroup);
			set => SetProperty(ref _choiceGroup, value);
		}

		[Ordinal(15)] 
		[RED("cpoHoldInputActionSection")] 
		public CBool CpoHoldInputActionSection
		{
			get => GetProperty(ref _cpoHoldInputActionSection);
			set => SetProperty(ref _cpoHoldInputActionSection, value);
		}

		[Ordinal(16)] 
		[RED("ataParams")] 
		public scnChoiceNodeNsAttachToActorParams AtaParams
		{
			get => GetProperty(ref _ataParams);
			set => SetProperty(ref _ataParams, value);
		}

		[Ordinal(17)] 
		[RED("atpParams")] 
		public scnChoiceNodeNsAttachToPropParams AtpParams
		{
			get => GetProperty(ref _atpParams);
			set => SetProperty(ref _atpParams, value);
		}

		[Ordinal(18)] 
		[RED("atgoParams")] 
		public scnChoiceNodeNsAttachToGameObjectParams AtgoParams
		{
			get => GetProperty(ref _atgoParams);
			set => SetProperty(ref _atgoParams, value);
		}

		[Ordinal(19)] 
		[RED("atsParams")] 
		public scnChoiceNodeNsAttachToScreenParams AtsParams
		{
			get => GetProperty(ref _atsParams);
			set => SetProperty(ref _atsParams, value);
		}

		[Ordinal(20)] 
		[RED("atwParams")] 
		public scnChoiceNodeNsAttachToWorldParams AtwParams
		{
			get => GetProperty(ref _atwParams);
			set => SetProperty(ref _atwParams, value);
		}

		[Ordinal(21)] 
		[RED("choicePriority")] 
		public CUInt8 ChoicePriority
		{
			get => GetProperty(ref _choicePriority);
			set => SetProperty(ref _choicePriority, value);
		}

		[Ordinal(22)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetProperty(ref _hubPriority);
			set => SetProperty(ref _hubPriority, value);
		}

		[Ordinal(23)] 
		[RED("mappinParams")] 
		public CHandle<scnChoiceNodeNsMappinParams> MappinParams
		{
			get => GetProperty(ref _mappinParams);
			set => SetProperty(ref _mappinParams, value);
		}

		[Ordinal(24)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get => GetProperty(ref _interruptCapability);
			set => SetProperty(ref _interruptCapability, value);
		}

		[Ordinal(25)] 
		[RED("interruptionSpeakerOverride")] 
		public scnActorId InterruptionSpeakerOverride
		{
			get => GetProperty(ref _interruptionSpeakerOverride);
			set => SetProperty(ref _interruptionSpeakerOverride, value);
		}

		[Ordinal(26)] 
		[RED("choiceFlags")] 
		public CEnum<scnChoiceNodeNsChoiceNodeBitFlags> ChoiceFlags
		{
			get => GetProperty(ref _choiceFlags);
			set => SetProperty(ref _choiceFlags, value);
		}

		[Ordinal(27)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get => GetProperty(ref _alwaysUseBrainGender);
			set => SetProperty(ref _alwaysUseBrainGender, value);
		}

		[Ordinal(28)] 
		[RED("timedSectionCondition")] 
		public CHandle<scnTimedCondition> TimedSectionCondition
		{
			get => GetProperty(ref _timedSectionCondition);
			set => SetProperty(ref _timedSectionCondition, value);
		}

		[Ordinal(29)] 
		[RED("reminderCondition")] 
		public CHandle<scnReminderCondition> ReminderCondition
		{
			get => GetProperty(ref _reminderCondition);
			set => SetProperty(ref _reminderCondition, value);
		}

		public scnChoiceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
