using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCombatVoSettings : audioAudioMetadata
	{
		private CName _answerGroupName;
		private CBool _isPlayerAlly;
		private CName _contexts;
		private CName _voTriggerVariations;
		private audioGeneralVoiceGruntSettings _generalGruntSettings;
		private audioVoiceTriggerLimits _voTriggerLimits;
		private CName _overridingVoTriggerLimits;
		private audioVoiceTriggerLimits _barkTriggerLimits;
		private audioVoiceTriggerLimits _gruntTriggerLimits;
		private CFloat _minDamageToInterruptVoWithPainShort;
		private CFloat _minDamageToInterruptVoWithPainLong;

		[Ordinal(1)] 
		[RED("answerGroupName")] 
		public CName AnswerGroupName
		{
			get
			{
				if (_answerGroupName == null)
				{
					_answerGroupName = (CName) CR2WTypeManager.Create("CName", "answerGroupName", cr2w, this);
				}
				return _answerGroupName;
			}
			set
			{
				if (_answerGroupName == value)
				{
					return;
				}
				_answerGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayerAlly")] 
		public CBool IsPlayerAlly
		{
			get
			{
				if (_isPlayerAlly == null)
				{
					_isPlayerAlly = (CBool) CR2WTypeManager.Create("Bool", "isPlayerAlly", cr2w, this);
				}
				return _isPlayerAlly;
			}
			set
			{
				if (_isPlayerAlly == value)
				{
					return;
				}
				_isPlayerAlly = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("contexts")] 
		public CName Contexts
		{
			get
			{
				if (_contexts == null)
				{
					_contexts = (CName) CR2WTypeManager.Create("CName", "contexts", cr2w, this);
				}
				return _contexts;
			}
			set
			{
				if (_contexts == value)
				{
					return;
				}
				_contexts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("voTriggerVariations")] 
		public CName VoTriggerVariations
		{
			get
			{
				if (_voTriggerVariations == null)
				{
					_voTriggerVariations = (CName) CR2WTypeManager.Create("CName", "voTriggerVariations", cr2w, this);
				}
				return _voTriggerVariations;
			}
			set
			{
				if (_voTriggerVariations == value)
				{
					return;
				}
				_voTriggerVariations = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("generalGruntSettings")] 
		public audioGeneralVoiceGruntSettings GeneralGruntSettings
		{
			get
			{
				if (_generalGruntSettings == null)
				{
					_generalGruntSettings = (audioGeneralVoiceGruntSettings) CR2WTypeManager.Create("audioGeneralVoiceGruntSettings", "generalGruntSettings", cr2w, this);
				}
				return _generalGruntSettings;
			}
			set
			{
				if (_generalGruntSettings == value)
				{
					return;
				}
				_generalGruntSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("voTriggerLimits")] 
		public audioVoiceTriggerLimits VoTriggerLimits
		{
			get
			{
				if (_voTriggerLimits == null)
				{
					_voTriggerLimits = (audioVoiceTriggerLimits) CR2WTypeManager.Create("audioVoiceTriggerLimits", "voTriggerLimits", cr2w, this);
				}
				return _voTriggerLimits;
			}
			set
			{
				if (_voTriggerLimits == value)
				{
					return;
				}
				_voTriggerLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("overridingVoTriggerLimits")] 
		public CName OverridingVoTriggerLimits
		{
			get
			{
				if (_overridingVoTriggerLimits == null)
				{
					_overridingVoTriggerLimits = (CName) CR2WTypeManager.Create("CName", "overridingVoTriggerLimits", cr2w, this);
				}
				return _overridingVoTriggerLimits;
			}
			set
			{
				if (_overridingVoTriggerLimits == value)
				{
					return;
				}
				_overridingVoTriggerLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("barkTriggerLimits")] 
		public audioVoiceTriggerLimits BarkTriggerLimits
		{
			get
			{
				if (_barkTriggerLimits == null)
				{
					_barkTriggerLimits = (audioVoiceTriggerLimits) CR2WTypeManager.Create("audioVoiceTriggerLimits", "barkTriggerLimits", cr2w, this);
				}
				return _barkTriggerLimits;
			}
			set
			{
				if (_barkTriggerLimits == value)
				{
					return;
				}
				_barkTriggerLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gruntTriggerLimits")] 
		public audioVoiceTriggerLimits GruntTriggerLimits
		{
			get
			{
				if (_gruntTriggerLimits == null)
				{
					_gruntTriggerLimits = (audioVoiceTriggerLimits) CR2WTypeManager.Create("audioVoiceTriggerLimits", "gruntTriggerLimits", cr2w, this);
				}
				return _gruntTriggerLimits;
			}
			set
			{
				if (_gruntTriggerLimits == value)
				{
					return;
				}
				_gruntTriggerLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("minDamageToInterruptVoWithPainShort")] 
		public CFloat MinDamageToInterruptVoWithPainShort
		{
			get
			{
				if (_minDamageToInterruptVoWithPainShort == null)
				{
					_minDamageToInterruptVoWithPainShort = (CFloat) CR2WTypeManager.Create("Float", "minDamageToInterruptVoWithPainShort", cr2w, this);
				}
				return _minDamageToInterruptVoWithPainShort;
			}
			set
			{
				if (_minDamageToInterruptVoWithPainShort == value)
				{
					return;
				}
				_minDamageToInterruptVoWithPainShort = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("minDamageToInterruptVoWithPainLong")] 
		public CFloat MinDamageToInterruptVoWithPainLong
		{
			get
			{
				if (_minDamageToInterruptVoWithPainLong == null)
				{
					_minDamageToInterruptVoWithPainLong = (CFloat) CR2WTypeManager.Create("Float", "minDamageToInterruptVoWithPainLong", cr2w, this);
				}
				return _minDamageToInterruptVoWithPainLong;
			}
			set
			{
				if (_minDamageToInterruptVoWithPainLong == value)
				{
					return;
				}
				_minDamageToInterruptVoWithPainLong = value;
				PropertySet(this);
			}
		}

		public audioCombatVoSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
