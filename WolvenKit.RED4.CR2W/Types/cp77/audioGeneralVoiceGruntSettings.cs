using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioGeneralVoiceGruntSettings : CVariable
	{
		private CUInt32 _variationsCount;
		private CName _painLong;
		private CName _agressionShort;
		private CName _agressionLong;
		private CName _longFall;
		private CName _death;
		private CName _silentDeath;
		private CName _grapple;
		private CName _grappleMovement;
		private CName _environmentalKnockdown;
		private CName _bump;
		private CName _curious;
		private CName _fear;
		private CName _jump;
		private CName _effortLong;
		private CName _deathShort;
		private CName _greet;
		private CName _laughHard;
		private CName _laughSoft;
		private CName _phone;
		private CName _braindanceExcited;
		private CName _braindanceFearful;
		private CName _braindanceNeutral;
		private CName _braindanceSexual;
		private audioContextualVoiceGruntSettings _contextualVoiceGruntSettings;
		private audioVoiceGruntVariations _gruntVariations;

		[Ordinal(0)] 
		[RED("variationsCount")] 
		public CUInt32 VariationsCount
		{
			get
			{
				if (_variationsCount == null)
				{
					_variationsCount = (CUInt32) CR2WTypeManager.Create("Uint32", "variationsCount", cr2w, this);
				}
				return _variationsCount;
			}
			set
			{
				if (_variationsCount == value)
				{
					return;
				}
				_variationsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("painLong")] 
		public CName PainLong
		{
			get
			{
				if (_painLong == null)
				{
					_painLong = (CName) CR2WTypeManager.Create("CName", "painLong", cr2w, this);
				}
				return _painLong;
			}
			set
			{
				if (_painLong == value)
				{
					return;
				}
				_painLong = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("agressionShort")] 
		public CName AgressionShort
		{
			get
			{
				if (_agressionShort == null)
				{
					_agressionShort = (CName) CR2WTypeManager.Create("CName", "agressionShort", cr2w, this);
				}
				return _agressionShort;
			}
			set
			{
				if (_agressionShort == value)
				{
					return;
				}
				_agressionShort = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("agressionLong")] 
		public CName AgressionLong
		{
			get
			{
				if (_agressionLong == null)
				{
					_agressionLong = (CName) CR2WTypeManager.Create("CName", "agressionLong", cr2w, this);
				}
				return _agressionLong;
			}
			set
			{
				if (_agressionLong == value)
				{
					return;
				}
				_agressionLong = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("longFall")] 
		public CName LongFall
		{
			get
			{
				if (_longFall == null)
				{
					_longFall = (CName) CR2WTypeManager.Create("CName", "longFall", cr2w, this);
				}
				return _longFall;
			}
			set
			{
				if (_longFall == value)
				{
					return;
				}
				_longFall = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("death")] 
		public CName Death
		{
			get
			{
				if (_death == null)
				{
					_death = (CName) CR2WTypeManager.Create("CName", "death", cr2w, this);
				}
				return _death;
			}
			set
			{
				if (_death == value)
				{
					return;
				}
				_death = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("silentDeath")] 
		public CName SilentDeath
		{
			get
			{
				if (_silentDeath == null)
				{
					_silentDeath = (CName) CR2WTypeManager.Create("CName", "silentDeath", cr2w, this);
				}
				return _silentDeath;
			}
			set
			{
				if (_silentDeath == value)
				{
					return;
				}
				_silentDeath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("grapple")] 
		public CName Grapple
		{
			get
			{
				if (_grapple == null)
				{
					_grapple = (CName) CR2WTypeManager.Create("CName", "grapple", cr2w, this);
				}
				return _grapple;
			}
			set
			{
				if (_grapple == value)
				{
					return;
				}
				_grapple = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("grappleMovement")] 
		public CName GrappleMovement
		{
			get
			{
				if (_grappleMovement == null)
				{
					_grappleMovement = (CName) CR2WTypeManager.Create("CName", "grappleMovement", cr2w, this);
				}
				return _grappleMovement;
			}
			set
			{
				if (_grappleMovement == value)
				{
					return;
				}
				_grappleMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("environmentalKnockdown")] 
		public CName EnvironmentalKnockdown
		{
			get
			{
				if (_environmentalKnockdown == null)
				{
					_environmentalKnockdown = (CName) CR2WTypeManager.Create("CName", "environmentalKnockdown", cr2w, this);
				}
				return _environmentalKnockdown;
			}
			set
			{
				if (_environmentalKnockdown == value)
				{
					return;
				}
				_environmentalKnockdown = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("bump")] 
		public CName Bump
		{
			get
			{
				if (_bump == null)
				{
					_bump = (CName) CR2WTypeManager.Create("CName", "bump", cr2w, this);
				}
				return _bump;
			}
			set
			{
				if (_bump == value)
				{
					return;
				}
				_bump = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("curious")] 
		public CName Curious
		{
			get
			{
				if (_curious == null)
				{
					_curious = (CName) CR2WTypeManager.Create("CName", "curious", cr2w, this);
				}
				return _curious;
			}
			set
			{
				if (_curious == value)
				{
					return;
				}
				_curious = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("fear")] 
		public CName Fear
		{
			get
			{
				if (_fear == null)
				{
					_fear = (CName) CR2WTypeManager.Create("CName", "fear", cr2w, this);
				}
				return _fear;
			}
			set
			{
				if (_fear == value)
				{
					return;
				}
				_fear = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("jump")] 
		public CName Jump
		{
			get
			{
				if (_jump == null)
				{
					_jump = (CName) CR2WTypeManager.Create("CName", "jump", cr2w, this);
				}
				return _jump;
			}
			set
			{
				if (_jump == value)
				{
					return;
				}
				_jump = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("effortLong")] 
		public CName EffortLong
		{
			get
			{
				if (_effortLong == null)
				{
					_effortLong = (CName) CR2WTypeManager.Create("CName", "effortLong", cr2w, this);
				}
				return _effortLong;
			}
			set
			{
				if (_effortLong == value)
				{
					return;
				}
				_effortLong = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("deathShort")] 
		public CName DeathShort
		{
			get
			{
				if (_deathShort == null)
				{
					_deathShort = (CName) CR2WTypeManager.Create("CName", "deathShort", cr2w, this);
				}
				return _deathShort;
			}
			set
			{
				if (_deathShort == value)
				{
					return;
				}
				_deathShort = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("greet")] 
		public CName Greet
		{
			get
			{
				if (_greet == null)
				{
					_greet = (CName) CR2WTypeManager.Create("CName", "greet", cr2w, this);
				}
				return _greet;
			}
			set
			{
				if (_greet == value)
				{
					return;
				}
				_greet = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("laughHard")] 
		public CName LaughHard
		{
			get
			{
				if (_laughHard == null)
				{
					_laughHard = (CName) CR2WTypeManager.Create("CName", "laughHard", cr2w, this);
				}
				return _laughHard;
			}
			set
			{
				if (_laughHard == value)
				{
					return;
				}
				_laughHard = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("laughSoft")] 
		public CName LaughSoft
		{
			get
			{
				if (_laughSoft == null)
				{
					_laughSoft = (CName) CR2WTypeManager.Create("CName", "laughSoft", cr2w, this);
				}
				return _laughSoft;
			}
			set
			{
				if (_laughSoft == value)
				{
					return;
				}
				_laughSoft = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("phone")] 
		public CName Phone
		{
			get
			{
				if (_phone == null)
				{
					_phone = (CName) CR2WTypeManager.Create("CName", "phone", cr2w, this);
				}
				return _phone;
			}
			set
			{
				if (_phone == value)
				{
					return;
				}
				_phone = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("braindanceExcited")] 
		public CName BraindanceExcited
		{
			get
			{
				if (_braindanceExcited == null)
				{
					_braindanceExcited = (CName) CR2WTypeManager.Create("CName", "braindanceExcited", cr2w, this);
				}
				return _braindanceExcited;
			}
			set
			{
				if (_braindanceExcited == value)
				{
					return;
				}
				_braindanceExcited = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("braindanceFearful")] 
		public CName BraindanceFearful
		{
			get
			{
				if (_braindanceFearful == null)
				{
					_braindanceFearful = (CName) CR2WTypeManager.Create("CName", "braindanceFearful", cr2w, this);
				}
				return _braindanceFearful;
			}
			set
			{
				if (_braindanceFearful == value)
				{
					return;
				}
				_braindanceFearful = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("braindanceNeutral")] 
		public CName BraindanceNeutral
		{
			get
			{
				if (_braindanceNeutral == null)
				{
					_braindanceNeutral = (CName) CR2WTypeManager.Create("CName", "braindanceNeutral", cr2w, this);
				}
				return _braindanceNeutral;
			}
			set
			{
				if (_braindanceNeutral == value)
				{
					return;
				}
				_braindanceNeutral = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("braindanceSexual")] 
		public CName BraindanceSexual
		{
			get
			{
				if (_braindanceSexual == null)
				{
					_braindanceSexual = (CName) CR2WTypeManager.Create("CName", "braindanceSexual", cr2w, this);
				}
				return _braindanceSexual;
			}
			set
			{
				if (_braindanceSexual == value)
				{
					return;
				}
				_braindanceSexual = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("contextualVoiceGruntSettings")] 
		public audioContextualVoiceGruntSettings ContextualVoiceGruntSettings
		{
			get
			{
				if (_contextualVoiceGruntSettings == null)
				{
					_contextualVoiceGruntSettings = (audioContextualVoiceGruntSettings) CR2WTypeManager.Create("audioContextualVoiceGruntSettings", "contextualVoiceGruntSettings", cr2w, this);
				}
				return _contextualVoiceGruntSettings;
			}
			set
			{
				if (_contextualVoiceGruntSettings == value)
				{
					return;
				}
				_contextualVoiceGruntSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("gruntVariations")] 
		public audioVoiceGruntVariations GruntVariations
		{
			get
			{
				if (_gruntVariations == null)
				{
					_gruntVariations = (audioVoiceGruntVariations) CR2WTypeManager.Create("audioVoiceGruntVariations", "gruntVariations", cr2w, this);
				}
				return _gruntVariations;
			}
			set
			{
				if (_gruntVariations == value)
				{
					return;
				}
				_gruntVariations = value;
				PropertySet(this);
			}
		}

		public audioGeneralVoiceGruntSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
