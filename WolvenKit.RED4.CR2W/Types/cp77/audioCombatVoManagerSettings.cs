using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoManagerSettings : audioAudioMetadata
	{
		private CFloat _thresholdDbForCombatDialog;
		private CFloat _maxVoHearableHorizontalDistance;
		private CFloat _maxVoHearableVerticalDistance;
		private CFloat _maxVoVisibleDistance;
		private CFloat _triggerVoEventBufferTime;
		private CFloat _triggerIdleChattersTime;
		private CFloat _minNoVOTimeNeededToTryPlayingGenericVO;
		private CFloat _specificVoicesetVoVariationMinRepeatTime;
		private CFloat _forceApucVoiceTagSelectionProbability;
		private CFloat _voiceTagSelectionRandomTimeOffset;
		private CArray<CName> _genericRelaxedVOContexts;
		private CArray<CName> _genericFearVOContexts;
		private CArray<CName> _genericAlertedVOContexts;
		private CArray<CName> _genericCombatVOContexts;
		private CArray<CName> _genericCombatLosingVOContexts;
		private CArray<CName> _genericCombatSingleEnemyVOContexts;

		[Ordinal(1)] 
		[RED("thresholdDbForCombatDialog")] 
		public CFloat ThresholdDbForCombatDialog
		{
			get
			{
				if (_thresholdDbForCombatDialog == null)
				{
					_thresholdDbForCombatDialog = (CFloat) CR2WTypeManager.Create("Float", "thresholdDbForCombatDialog", cr2w, this);
				}
				return _thresholdDbForCombatDialog;
			}
			set
			{
				if (_thresholdDbForCombatDialog == value)
				{
					return;
				}
				_thresholdDbForCombatDialog = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxVoHearableHorizontalDistance")] 
		public CFloat MaxVoHearableHorizontalDistance
		{
			get
			{
				if (_maxVoHearableHorizontalDistance == null)
				{
					_maxVoHearableHorizontalDistance = (CFloat) CR2WTypeManager.Create("Float", "maxVoHearableHorizontalDistance", cr2w, this);
				}
				return _maxVoHearableHorizontalDistance;
			}
			set
			{
				if (_maxVoHearableHorizontalDistance == value)
				{
					return;
				}
				_maxVoHearableHorizontalDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxVoHearableVerticalDistance")] 
		public CFloat MaxVoHearableVerticalDistance
		{
			get
			{
				if (_maxVoHearableVerticalDistance == null)
				{
					_maxVoHearableVerticalDistance = (CFloat) CR2WTypeManager.Create("Float", "maxVoHearableVerticalDistance", cr2w, this);
				}
				return _maxVoHearableVerticalDistance;
			}
			set
			{
				if (_maxVoHearableVerticalDistance == value)
				{
					return;
				}
				_maxVoHearableVerticalDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxVoVisibleDistance")] 
		public CFloat MaxVoVisibleDistance
		{
			get
			{
				if (_maxVoVisibleDistance == null)
				{
					_maxVoVisibleDistance = (CFloat) CR2WTypeManager.Create("Float", "maxVoVisibleDistance", cr2w, this);
				}
				return _maxVoVisibleDistance;
			}
			set
			{
				if (_maxVoVisibleDistance == value)
				{
					return;
				}
				_maxVoVisibleDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("triggerVoEventBufferTime")] 
		public CFloat TriggerVoEventBufferTime
		{
			get
			{
				if (_triggerVoEventBufferTime == null)
				{
					_triggerVoEventBufferTime = (CFloat) CR2WTypeManager.Create("Float", "triggerVoEventBufferTime", cr2w, this);
				}
				return _triggerVoEventBufferTime;
			}
			set
			{
				if (_triggerVoEventBufferTime == value)
				{
					return;
				}
				_triggerVoEventBufferTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("triggerIdleChattersTime")] 
		public CFloat TriggerIdleChattersTime
		{
			get
			{
				if (_triggerIdleChattersTime == null)
				{
					_triggerIdleChattersTime = (CFloat) CR2WTypeManager.Create("Float", "triggerIdleChattersTime", cr2w, this);
				}
				return _triggerIdleChattersTime;
			}
			set
			{
				if (_triggerIdleChattersTime == value)
				{
					return;
				}
				_triggerIdleChattersTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("minNoVOTimeNeededToTryPlayingGenericVO")] 
		public CFloat MinNoVOTimeNeededToTryPlayingGenericVO
		{
			get
			{
				if (_minNoVOTimeNeededToTryPlayingGenericVO == null)
				{
					_minNoVOTimeNeededToTryPlayingGenericVO = (CFloat) CR2WTypeManager.Create("Float", "minNoVOTimeNeededToTryPlayingGenericVO", cr2w, this);
				}
				return _minNoVOTimeNeededToTryPlayingGenericVO;
			}
			set
			{
				if (_minNoVOTimeNeededToTryPlayingGenericVO == value)
				{
					return;
				}
				_minNoVOTimeNeededToTryPlayingGenericVO = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("specificVoicesetVoVariationMinRepeatTime")] 
		public CFloat SpecificVoicesetVoVariationMinRepeatTime
		{
			get
			{
				if (_specificVoicesetVoVariationMinRepeatTime == null)
				{
					_specificVoicesetVoVariationMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "specificVoicesetVoVariationMinRepeatTime", cr2w, this);
				}
				return _specificVoicesetVoVariationMinRepeatTime;
			}
			set
			{
				if (_specificVoicesetVoVariationMinRepeatTime == value)
				{
					return;
				}
				_specificVoicesetVoVariationMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("forceApucVoiceTagSelectionProbability")] 
		public CFloat ForceApucVoiceTagSelectionProbability
		{
			get
			{
				if (_forceApucVoiceTagSelectionProbability == null)
				{
					_forceApucVoiceTagSelectionProbability = (CFloat) CR2WTypeManager.Create("Float", "forceApucVoiceTagSelectionProbability", cr2w, this);
				}
				return _forceApucVoiceTagSelectionProbability;
			}
			set
			{
				if (_forceApucVoiceTagSelectionProbability == value)
				{
					return;
				}
				_forceApucVoiceTagSelectionProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("voiceTagSelectionRandomTimeOffset")] 
		public CFloat VoiceTagSelectionRandomTimeOffset
		{
			get
			{
				if (_voiceTagSelectionRandomTimeOffset == null)
				{
					_voiceTagSelectionRandomTimeOffset = (CFloat) CR2WTypeManager.Create("Float", "voiceTagSelectionRandomTimeOffset", cr2w, this);
				}
				return _voiceTagSelectionRandomTimeOffset;
			}
			set
			{
				if (_voiceTagSelectionRandomTimeOffset == value)
				{
					return;
				}
				_voiceTagSelectionRandomTimeOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("genericRelaxedVOContexts")] 
		public CArray<CName> GenericRelaxedVOContexts
		{
			get
			{
				if (_genericRelaxedVOContexts == null)
				{
					_genericRelaxedVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericRelaxedVOContexts", cr2w, this);
				}
				return _genericRelaxedVOContexts;
			}
			set
			{
				if (_genericRelaxedVOContexts == value)
				{
					return;
				}
				_genericRelaxedVOContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("genericFearVOContexts")] 
		public CArray<CName> GenericFearVOContexts
		{
			get
			{
				if (_genericFearVOContexts == null)
				{
					_genericFearVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericFearVOContexts", cr2w, this);
				}
				return _genericFearVOContexts;
			}
			set
			{
				if (_genericFearVOContexts == value)
				{
					return;
				}
				_genericFearVOContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("genericAlertedVOContexts")] 
		public CArray<CName> GenericAlertedVOContexts
		{
			get
			{
				if (_genericAlertedVOContexts == null)
				{
					_genericAlertedVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericAlertedVOContexts", cr2w, this);
				}
				return _genericAlertedVOContexts;
			}
			set
			{
				if (_genericAlertedVOContexts == value)
				{
					return;
				}
				_genericAlertedVOContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("genericCombatVOContexts")] 
		public CArray<CName> GenericCombatVOContexts
		{
			get
			{
				if (_genericCombatVOContexts == null)
				{
					_genericCombatVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericCombatVOContexts", cr2w, this);
				}
				return _genericCombatVOContexts;
			}
			set
			{
				if (_genericCombatVOContexts == value)
				{
					return;
				}
				_genericCombatVOContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("genericCombatLosingVOContexts")] 
		public CArray<CName> GenericCombatLosingVOContexts
		{
			get
			{
				if (_genericCombatLosingVOContexts == null)
				{
					_genericCombatLosingVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericCombatLosingVOContexts", cr2w, this);
				}
				return _genericCombatLosingVOContexts;
			}
			set
			{
				if (_genericCombatLosingVOContexts == value)
				{
					return;
				}
				_genericCombatLosingVOContexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("genericCombatSingleEnemyVOContexts")] 
		public CArray<CName> GenericCombatSingleEnemyVOContexts
		{
			get
			{
				if (_genericCombatSingleEnemyVOContexts == null)
				{
					_genericCombatSingleEnemyVOContexts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "genericCombatSingleEnemyVOContexts", cr2w, this);
				}
				return _genericCombatSingleEnemyVOContexts;
			}
			set
			{
				if (_genericCombatSingleEnemyVOContexts == value)
				{
					return;
				}
				_genericCombatSingleEnemyVOContexts = value;
				PropertySet(this);
			}
		}

		public audioCombatVoManagerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
