using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDroneMetadata : audioCustomEmitterMetadata
	{
		private CName _boneName;
		private CName _engineStart;
		private CName _engineStop;
		private CName _combatEnter;
		private CName _combatExit;
		private CName _targetLost;
		private CName _idle;
		private CName _initialReaction;
		private CName _investigationIgnore;
		private CName _noClearShot;
		private CName _targetComplies;
		private CName _lookForIntruder;
		private CName _droneDestroyed;
		private CName _droneDefeated;
		private CName _commandHolsterWeapon;
		private CName _commandLeaveArea;
		private CName _finalWarning;
		private CFloat _playDistance;
		private CArray<CName> _decorators;

		[Ordinal(1)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("engineStart")] 
		public CName EngineStart
		{
			get
			{
				if (_engineStart == null)
				{
					_engineStart = (CName) CR2WTypeManager.Create("CName", "engineStart", cr2w, this);
				}
				return _engineStart;
			}
			set
			{
				if (_engineStart == value)
				{
					return;
				}
				_engineStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("engineStop")] 
		public CName EngineStop
		{
			get
			{
				if (_engineStop == null)
				{
					_engineStop = (CName) CR2WTypeManager.Create("CName", "engineStop", cr2w, this);
				}
				return _engineStop;
			}
			set
			{
				if (_engineStop == value)
				{
					return;
				}
				_engineStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("combatEnter")] 
		public CName CombatEnter
		{
			get
			{
				if (_combatEnter == null)
				{
					_combatEnter = (CName) CR2WTypeManager.Create("CName", "combatEnter", cr2w, this);
				}
				return _combatEnter;
			}
			set
			{
				if (_combatEnter == value)
				{
					return;
				}
				_combatEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("combatExit")] 
		public CName CombatExit
		{
			get
			{
				if (_combatExit == null)
				{
					_combatExit = (CName) CR2WTypeManager.Create("CName", "combatExit", cr2w, this);
				}
				return _combatExit;
			}
			set
			{
				if (_combatExit == value)
				{
					return;
				}
				_combatExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetLost")] 
		public CName TargetLost
		{
			get
			{
				if (_targetLost == null)
				{
					_targetLost = (CName) CR2WTypeManager.Create("CName", "targetLost", cr2w, this);
				}
				return _targetLost;
			}
			set
			{
				if (_targetLost == value)
				{
					return;
				}
				_targetLost = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("idle")] 
		public CName Idle
		{
			get
			{
				if (_idle == null)
				{
					_idle = (CName) CR2WTypeManager.Create("CName", "idle", cr2w, this);
				}
				return _idle;
			}
			set
			{
				if (_idle == value)
				{
					return;
				}
				_idle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("initialReaction")] 
		public CName InitialReaction
		{
			get
			{
				if (_initialReaction == null)
				{
					_initialReaction = (CName) CR2WTypeManager.Create("CName", "initialReaction", cr2w, this);
				}
				return _initialReaction;
			}
			set
			{
				if (_initialReaction == value)
				{
					return;
				}
				_initialReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("investigationIgnore")] 
		public CName InvestigationIgnore
		{
			get
			{
				if (_investigationIgnore == null)
				{
					_investigationIgnore = (CName) CR2WTypeManager.Create("CName", "investigationIgnore", cr2w, this);
				}
				return _investigationIgnore;
			}
			set
			{
				if (_investigationIgnore == value)
				{
					return;
				}
				_investigationIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("noClearShot")] 
		public CName NoClearShot
		{
			get
			{
				if (_noClearShot == null)
				{
					_noClearShot = (CName) CR2WTypeManager.Create("CName", "noClearShot", cr2w, this);
				}
				return _noClearShot;
			}
			set
			{
				if (_noClearShot == value)
				{
					return;
				}
				_noClearShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("targetComplies")] 
		public CName TargetComplies
		{
			get
			{
				if (_targetComplies == null)
				{
					_targetComplies = (CName) CR2WTypeManager.Create("CName", "targetComplies", cr2w, this);
				}
				return _targetComplies;
			}
			set
			{
				if (_targetComplies == value)
				{
					return;
				}
				_targetComplies = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lookForIntruder")] 
		public CName LookForIntruder
		{
			get
			{
				if (_lookForIntruder == null)
				{
					_lookForIntruder = (CName) CR2WTypeManager.Create("CName", "lookForIntruder", cr2w, this);
				}
				return _lookForIntruder;
			}
			set
			{
				if (_lookForIntruder == value)
				{
					return;
				}
				_lookForIntruder = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("droneDestroyed")] 
		public CName DroneDestroyed
		{
			get
			{
				if (_droneDestroyed == null)
				{
					_droneDestroyed = (CName) CR2WTypeManager.Create("CName", "droneDestroyed", cr2w, this);
				}
				return _droneDestroyed;
			}
			set
			{
				if (_droneDestroyed == value)
				{
					return;
				}
				_droneDestroyed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("droneDefeated")] 
		public CName DroneDefeated
		{
			get
			{
				if (_droneDefeated == null)
				{
					_droneDefeated = (CName) CR2WTypeManager.Create("CName", "droneDefeated", cr2w, this);
				}
				return _droneDefeated;
			}
			set
			{
				if (_droneDefeated == value)
				{
					return;
				}
				_droneDefeated = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("commandHolsterWeapon")] 
		public CName CommandHolsterWeapon
		{
			get
			{
				if (_commandHolsterWeapon == null)
				{
					_commandHolsterWeapon = (CName) CR2WTypeManager.Create("CName", "commandHolsterWeapon", cr2w, this);
				}
				return _commandHolsterWeapon;
			}
			set
			{
				if (_commandHolsterWeapon == value)
				{
					return;
				}
				_commandHolsterWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("commandLeaveArea")] 
		public CName CommandLeaveArea
		{
			get
			{
				if (_commandLeaveArea == null)
				{
					_commandLeaveArea = (CName) CR2WTypeManager.Create("CName", "commandLeaveArea", cr2w, this);
				}
				return _commandLeaveArea;
			}
			set
			{
				if (_commandLeaveArea == value)
				{
					return;
				}
				_commandLeaveArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("finalWarning")] 
		public CName FinalWarning
		{
			get
			{
				if (_finalWarning == null)
				{
					_finalWarning = (CName) CR2WTypeManager.Create("CName", "finalWarning", cr2w, this);
				}
				return _finalWarning;
			}
			set
			{
				if (_finalWarning == value)
				{
					return;
				}
				_finalWarning = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("playDistance")] 
		public CFloat PlayDistance
		{
			get
			{
				if (_playDistance == null)
				{
					_playDistance = (CFloat) CR2WTypeManager.Create("Float", "playDistance", cr2w, this);
				}
				return _playDistance;
			}
			set
			{
				if (_playDistance == value)
				{
					return;
				}
				_playDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("decorators")] 
		public CArray<CName> Decorators
		{
			get
			{
				if (_decorators == null)
				{
					_decorators = (CArray<CName>) CR2WTypeManager.Create("array:CName", "decorators", cr2w, this);
				}
				return _decorators;
			}
			set
			{
				if (_decorators == value)
				{
					return;
				}
				_decorators = value;
				PropertySet(this);
			}
		}

		public audioDroneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
