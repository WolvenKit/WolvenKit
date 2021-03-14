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
			get
			{
				if (_displayNameOverride == null)
				{
					_displayNameOverride = (CString) CR2WTypeManager.Create("String", "displayNameOverride", cr2w, this);
				}
				return _displayNameOverride;
			}
			set
			{
				if (_displayNameOverride == value)
				{
					return;
				}
				_displayNameOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("localizedDisplayNameOverride")] 
		public LocalizationString LocalizedDisplayNameOverride
		{
			get
			{
				if (_localizedDisplayNameOverride == null)
				{
					_localizedDisplayNameOverride = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "localizedDisplayNameOverride", cr2w, this);
				}
				return _localizedDisplayNameOverride;
			}
			set
			{
				if (_localizedDisplayNameOverride == value)
				{
					return;
				}
				_localizedDisplayNameOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("options")] 
		public CArray<scnChoiceNodeOption> Options
		{
			get
			{
				if (_options == null)
				{
					_options = (CArray<scnChoiceNodeOption>) CR2WTypeManager.Create("array:scnChoiceNodeOption", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CEnum<scnChoiceNodeNsOperationMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<scnChoiceNodeNsOperationMode>) CR2WTypeManager.Create("scnChoiceNodeNsOperationMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("persistentLineEvents")] 
		public CArray<scnSceneEventId> PersistentLineEvents
		{
			get
			{
				if (_persistentLineEvents == null)
				{
					_persistentLineEvents = (CArray<scnSceneEventId>) CR2WTypeManager.Create("array:scnSceneEventId", "persistentLineEvents", cr2w, this);
				}
				return _persistentLineEvents;
			}
			set
			{
				if (_persistentLineEvents == value)
				{
					return;
				}
				_persistentLineEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("customPersistentLine")] 
		public scnscreenplayItemId CustomPersistentLine
		{
			get
			{
				if (_customPersistentLine == null)
				{
					_customPersistentLine = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "customPersistentLine", cr2w, this);
				}
				return _customPersistentLine;
			}
			set
			{
				if (_customPersistentLine == value)
				{
					return;
				}
				_customPersistentLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get
			{
				if (_timedParams == null)
				{
					_timedParams = (CHandle<scnChoiceNodeNsTimedParams>) CR2WTypeManager.Create("handle:scnChoiceNodeNsTimedParams", "timedParams", cr2w, this);
				}
				return _timedParams;
			}
			set
			{
				if (_timedParams == value)
				{
					return;
				}
				_timedParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("reminderParams")] 
		public CHandle<scnChoiceNodeNsActorReminderParams> ReminderParams
		{
			get
			{
				if (_reminderParams == null)
				{
					_reminderParams = (CHandle<scnChoiceNodeNsActorReminderParams>) CR2WTypeManager.Create("handle:scnChoiceNodeNsActorReminderParams", "reminderParams", cr2w, this);
				}
				return _reminderParams;
			}
			set
			{
				if (_reminderParams == value)
				{
					return;
				}
				_reminderParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("shapeParams")] 
		public CHandle<scnInteractionShapeParams> ShapeParams
		{
			get
			{
				if (_shapeParams == null)
				{
					_shapeParams = (CHandle<scnInteractionShapeParams>) CR2WTypeManager.Create("handle:scnInteractionShapeParams", "shapeParams", cr2w, this);
				}
				return _shapeParams;
			}
			set
			{
				if (_shapeParams == value)
				{
					return;
				}
				_shapeParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lookAtParams")] 
		public CHandle<scnChoiceNodeNsLookAtParams> LookAtParams
		{
			get
			{
				if (_lookAtParams == null)
				{
					_lookAtParams = (CHandle<scnChoiceNodeNsLookAtParams>) CR2WTypeManager.Create("handle:scnChoiceNodeNsLookAtParams", "lookAtParams", cr2w, this);
				}
				return _lookAtParams;
			}
			set
			{
				if (_lookAtParams == value)
				{
					return;
				}
				_lookAtParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("forceAttachToScreenCondition")] 
		public CHandle<questIBaseCondition> ForceAttachToScreenCondition
		{
			get
			{
				if (_forceAttachToScreenCondition == null)
				{
					_forceAttachToScreenCondition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "forceAttachToScreenCondition", cr2w, this);
				}
				return _forceAttachToScreenCondition;
			}
			set
			{
				if (_forceAttachToScreenCondition == value)
				{
					return;
				}
				_forceAttachToScreenCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("choiceGroup")] 
		public CName ChoiceGroup
		{
			get
			{
				if (_choiceGroup == null)
				{
					_choiceGroup = (CName) CR2WTypeManager.Create("CName", "choiceGroup", cr2w, this);
				}
				return _choiceGroup;
			}
			set
			{
				if (_choiceGroup == value)
				{
					return;
				}
				_choiceGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("cpoHoldInputActionSection")] 
		public CBool CpoHoldInputActionSection
		{
			get
			{
				if (_cpoHoldInputActionSection == null)
				{
					_cpoHoldInputActionSection = (CBool) CR2WTypeManager.Create("Bool", "cpoHoldInputActionSection", cr2w, this);
				}
				return _cpoHoldInputActionSection;
			}
			set
			{
				if (_cpoHoldInputActionSection == value)
				{
					return;
				}
				_cpoHoldInputActionSection = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ataParams")] 
		public scnChoiceNodeNsAttachToActorParams AtaParams
		{
			get
			{
				if (_ataParams == null)
				{
					_ataParams = (scnChoiceNodeNsAttachToActorParams) CR2WTypeManager.Create("scnChoiceNodeNsAttachToActorParams", "ataParams", cr2w, this);
				}
				return _ataParams;
			}
			set
			{
				if (_ataParams == value)
				{
					return;
				}
				_ataParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("atpParams")] 
		public scnChoiceNodeNsAttachToPropParams AtpParams
		{
			get
			{
				if (_atpParams == null)
				{
					_atpParams = (scnChoiceNodeNsAttachToPropParams) CR2WTypeManager.Create("scnChoiceNodeNsAttachToPropParams", "atpParams", cr2w, this);
				}
				return _atpParams;
			}
			set
			{
				if (_atpParams == value)
				{
					return;
				}
				_atpParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("atgoParams")] 
		public scnChoiceNodeNsAttachToGameObjectParams AtgoParams
		{
			get
			{
				if (_atgoParams == null)
				{
					_atgoParams = (scnChoiceNodeNsAttachToGameObjectParams) CR2WTypeManager.Create("scnChoiceNodeNsAttachToGameObjectParams", "atgoParams", cr2w, this);
				}
				return _atgoParams;
			}
			set
			{
				if (_atgoParams == value)
				{
					return;
				}
				_atgoParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("atsParams")] 
		public scnChoiceNodeNsAttachToScreenParams AtsParams
		{
			get
			{
				if (_atsParams == null)
				{
					_atsParams = (scnChoiceNodeNsAttachToScreenParams) CR2WTypeManager.Create("scnChoiceNodeNsAttachToScreenParams", "atsParams", cr2w, this);
				}
				return _atsParams;
			}
			set
			{
				if (_atsParams == value)
				{
					return;
				}
				_atsParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("atwParams")] 
		public scnChoiceNodeNsAttachToWorldParams AtwParams
		{
			get
			{
				if (_atwParams == null)
				{
					_atwParams = (scnChoiceNodeNsAttachToWorldParams) CR2WTypeManager.Create("scnChoiceNodeNsAttachToWorldParams", "atwParams", cr2w, this);
				}
				return _atwParams;
			}
			set
			{
				if (_atwParams == value)
				{
					return;
				}
				_atwParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("choicePriority")] 
		public CUInt8 ChoicePriority
		{
			get
			{
				if (_choicePriority == null)
				{
					_choicePriority = (CUInt8) CR2WTypeManager.Create("Uint8", "choicePriority", cr2w, this);
				}
				return _choicePriority;
			}
			set
			{
				if (_choicePriority == value)
				{
					return;
				}
				_choicePriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get
			{
				if (_hubPriority == null)
				{
					_hubPriority = (CUInt8) CR2WTypeManager.Create("Uint8", "hubPriority", cr2w, this);
				}
				return _hubPriority;
			}
			set
			{
				if (_hubPriority == value)
				{
					return;
				}
				_hubPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("mappinParams")] 
		public CHandle<scnChoiceNodeNsMappinParams> MappinParams
		{
			get
			{
				if (_mappinParams == null)
				{
					_mappinParams = (CHandle<scnChoiceNodeNsMappinParams>) CR2WTypeManager.Create("handle:scnChoiceNodeNsMappinParams", "mappinParams", cr2w, this);
				}
				return _mappinParams;
			}
			set
			{
				if (_mappinParams == value)
				{
					return;
				}
				_mappinParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get
			{
				if (_interruptCapability == null)
				{
					_interruptCapability = (CEnum<scnInterruptCapability>) CR2WTypeManager.Create("scnInterruptCapability", "interruptCapability", cr2w, this);
				}
				return _interruptCapability;
			}
			set
			{
				if (_interruptCapability == value)
				{
					return;
				}
				_interruptCapability = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("interruptionSpeakerOverride")] 
		public scnActorId InterruptionSpeakerOverride
		{
			get
			{
				if (_interruptionSpeakerOverride == null)
				{
					_interruptionSpeakerOverride = (scnActorId) CR2WTypeManager.Create("scnActorId", "interruptionSpeakerOverride", cr2w, this);
				}
				return _interruptionSpeakerOverride;
			}
			set
			{
				if (_interruptionSpeakerOverride == value)
				{
					return;
				}
				_interruptionSpeakerOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("choiceFlags")] 
		public CEnum<scnChoiceNodeNsChoiceNodeBitFlags> ChoiceFlags
		{
			get
			{
				if (_choiceFlags == null)
				{
					_choiceFlags = (CEnum<scnChoiceNodeNsChoiceNodeBitFlags>) CR2WTypeManager.Create("scnChoiceNodeNsChoiceNodeBitFlags", "choiceFlags", cr2w, this);
				}
				return _choiceFlags;
			}
			set
			{
				if (_choiceFlags == value)
				{
					return;
				}
				_choiceFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("alwaysUseBrainGender")] 
		public CBool AlwaysUseBrainGender
		{
			get
			{
				if (_alwaysUseBrainGender == null)
				{
					_alwaysUseBrainGender = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseBrainGender", cr2w, this);
				}
				return _alwaysUseBrainGender;
			}
			set
			{
				if (_alwaysUseBrainGender == value)
				{
					return;
				}
				_alwaysUseBrainGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("timedSectionCondition")] 
		public CHandle<scnTimedCondition> TimedSectionCondition
		{
			get
			{
				if (_timedSectionCondition == null)
				{
					_timedSectionCondition = (CHandle<scnTimedCondition>) CR2WTypeManager.Create("handle:scnTimedCondition", "timedSectionCondition", cr2w, this);
				}
				return _timedSectionCondition;
			}
			set
			{
				if (_timedSectionCondition == value)
				{
					return;
				}
				_timedSectionCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("reminderCondition")] 
		public CHandle<scnReminderCondition> ReminderCondition
		{
			get
			{
				if (_reminderCondition == null)
				{
					_reminderCondition = (CHandle<scnReminderCondition>) CR2WTypeManager.Create("handle:scnReminderCondition", "reminderCondition", cr2w, this);
				}
				return _reminderCondition;
			}
			set
			{
				if (_reminderCondition == value)
				{
					return;
				}
				_reminderCondition = value;
				PropertySet(this);
			}
		}

		public scnChoiceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
