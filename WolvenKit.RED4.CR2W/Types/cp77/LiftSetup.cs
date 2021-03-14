using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftSetup : CVariable
	{
		private CInt32 _startingFloorTerminal;
		private CFloat _liftSpeed;
		private CFloat _liftStartingDelay;
		private CFloat _liftTravelTimeOverride;
		private CBool _isLiftTravelTimeOverride;
		private CFloat _emptyLiftSpeedMultiplier;
		private CInt32 _radioStationNumer;
		private CName _speakerDestroyedQuestFact;
		private CName _speakerDestroyedVFX;
		private CString _authorizationTextOverride;

		[Ordinal(0)] 
		[RED("startingFloorTerminal")] 
		public CInt32 StartingFloorTerminal
		{
			get
			{
				if (_startingFloorTerminal == null)
				{
					_startingFloorTerminal = (CInt32) CR2WTypeManager.Create("Int32", "startingFloorTerminal", cr2w, this);
				}
				return _startingFloorTerminal;
			}
			set
			{
				if (_startingFloorTerminal == value)
				{
					return;
				}
				_startingFloorTerminal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("liftSpeed")] 
		public CFloat LiftSpeed
		{
			get
			{
				if (_liftSpeed == null)
				{
					_liftSpeed = (CFloat) CR2WTypeManager.Create("Float", "liftSpeed", cr2w, this);
				}
				return _liftSpeed;
			}
			set
			{
				if (_liftSpeed == value)
				{
					return;
				}
				_liftSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("liftStartingDelay")] 
		public CFloat LiftStartingDelay
		{
			get
			{
				if (_liftStartingDelay == null)
				{
					_liftStartingDelay = (CFloat) CR2WTypeManager.Create("Float", "liftStartingDelay", cr2w, this);
				}
				return _liftStartingDelay;
			}
			set
			{
				if (_liftStartingDelay == value)
				{
					return;
				}
				_liftStartingDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("liftTravelTimeOverride")] 
		public CFloat LiftTravelTimeOverride
		{
			get
			{
				if (_liftTravelTimeOverride == null)
				{
					_liftTravelTimeOverride = (CFloat) CR2WTypeManager.Create("Float", "liftTravelTimeOverride", cr2w, this);
				}
				return _liftTravelTimeOverride;
			}
			set
			{
				if (_liftTravelTimeOverride == value)
				{
					return;
				}
				_liftTravelTimeOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isLiftTravelTimeOverride")] 
		public CBool IsLiftTravelTimeOverride
		{
			get
			{
				if (_isLiftTravelTimeOverride == null)
				{
					_isLiftTravelTimeOverride = (CBool) CR2WTypeManager.Create("Bool", "isLiftTravelTimeOverride", cr2w, this);
				}
				return _isLiftTravelTimeOverride;
			}
			set
			{
				if (_isLiftTravelTimeOverride == value)
				{
					return;
				}
				_isLiftTravelTimeOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("emptyLiftSpeedMultiplier")] 
		public CFloat EmptyLiftSpeedMultiplier
		{
			get
			{
				if (_emptyLiftSpeedMultiplier == null)
				{
					_emptyLiftSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "emptyLiftSpeedMultiplier", cr2w, this);
				}
				return _emptyLiftSpeedMultiplier;
			}
			set
			{
				if (_emptyLiftSpeedMultiplier == value)
				{
					return;
				}
				_emptyLiftSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("radioStationNumer")] 
		public CInt32 RadioStationNumer
		{
			get
			{
				if (_radioStationNumer == null)
				{
					_radioStationNumer = (CInt32) CR2WTypeManager.Create("Int32", "radioStationNumer", cr2w, this);
				}
				return _radioStationNumer;
			}
			set
			{
				if (_radioStationNumer == value)
				{
					return;
				}
				_radioStationNumer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("speakerDestroyedQuestFact")] 
		public CName SpeakerDestroyedQuestFact
		{
			get
			{
				if (_speakerDestroyedQuestFact == null)
				{
					_speakerDestroyedQuestFact = (CName) CR2WTypeManager.Create("CName", "speakerDestroyedQuestFact", cr2w, this);
				}
				return _speakerDestroyedQuestFact;
			}
			set
			{
				if (_speakerDestroyedQuestFact == value)
				{
					return;
				}
				_speakerDestroyedQuestFact = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("speakerDestroyedVFX")] 
		public CName SpeakerDestroyedVFX
		{
			get
			{
				if (_speakerDestroyedVFX == null)
				{
					_speakerDestroyedVFX = (CName) CR2WTypeManager.Create("CName", "speakerDestroyedVFX", cr2w, this);
				}
				return _speakerDestroyedVFX;
			}
			set
			{
				if (_speakerDestroyedVFX == value)
				{
					return;
				}
				_speakerDestroyedVFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get
			{
				if (_authorizationTextOverride == null)
				{
					_authorizationTextOverride = (CString) CR2WTypeManager.Create("String", "authorizationTextOverride", cr2w, this);
				}
				return _authorizationTextOverride;
			}
			set
			{
				if (_authorizationTextOverride == value)
				{
					return;
				}
				_authorizationTextOverride = value;
				PropertySet(this);
			}
		}

		public LiftSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
