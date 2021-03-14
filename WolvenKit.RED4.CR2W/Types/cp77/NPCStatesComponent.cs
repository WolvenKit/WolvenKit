using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStatesComponent : gameAINetStateComponent
	{
		private CHandle<entLookAtAddEvent> _aimingLookatEvent;
		private CName _highLevelAnimFeatureName;
		private CName _upperBodyAnimFeatureName;
		private CName _stanceAnimFeatureName;
		private CHandle<gameStatModifierData> _statFlagDefensiveState;
		private CEnum<gamedataNPCStanceState> _prevNPCStanceState;
		private CEnum<gamedataNPCHighLevelState> _previousHighLevelState;
		private CEnum<EHitReactionMode> _prevHitReactionMode;
		private TweakDBID _bulkyStaggerMinRecordID;
		private TweakDBID _staggerMinRecordID;
		private TweakDBID _unstoppableRecordID;
		private TweakDBID _unstoppableTwitchMinRecordID;
		private TweakDBID _unstoppableTwitchNoneRecordID;
		private TweakDBID _forceImpactRecordID;
		private TweakDBID _forceStaggerRecordID;
		private TweakDBID _forceKnockdownRecordID;
		private TweakDBID _fragileRecordID;
		private TweakDBID _weakRecordID;
		private TweakDBID _toughRecordID;
		private TweakDBID _bulkyRecordID;
		private TweakDBID _regularRecordID;
		private CBool _inCombat;

		[Ordinal(5)] 
		[RED("aimingLookatEvent")] 
		public CHandle<entLookAtAddEvent> AimingLookatEvent
		{
			get
			{
				if (_aimingLookatEvent == null)
				{
					_aimingLookatEvent = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "aimingLookatEvent", cr2w, this);
				}
				return _aimingLookatEvent;
			}
			set
			{
				if (_aimingLookatEvent == value)
				{
					return;
				}
				_aimingLookatEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("highLevelAnimFeatureName")] 
		public CName HighLevelAnimFeatureName
		{
			get
			{
				if (_highLevelAnimFeatureName == null)
				{
					_highLevelAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "highLevelAnimFeatureName", cr2w, this);
				}
				return _highLevelAnimFeatureName;
			}
			set
			{
				if (_highLevelAnimFeatureName == value)
				{
					return;
				}
				_highLevelAnimFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("upperBodyAnimFeatureName")] 
		public CName UpperBodyAnimFeatureName
		{
			get
			{
				if (_upperBodyAnimFeatureName == null)
				{
					_upperBodyAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "upperBodyAnimFeatureName", cr2w, this);
				}
				return _upperBodyAnimFeatureName;
			}
			set
			{
				if (_upperBodyAnimFeatureName == value)
				{
					return;
				}
				_upperBodyAnimFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get
			{
				if (_stanceAnimFeatureName == null)
				{
					_stanceAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "stanceAnimFeatureName", cr2w, this);
				}
				return _stanceAnimFeatureName;
			}
			set
			{
				if (_stanceAnimFeatureName == value)
				{
					return;
				}
				_stanceAnimFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statFlagDefensiveState")] 
		public CHandle<gameStatModifierData> StatFlagDefensiveState
		{
			get
			{
				if (_statFlagDefensiveState == null)
				{
					_statFlagDefensiveState = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "statFlagDefensiveState", cr2w, this);
				}
				return _statFlagDefensiveState;
			}
			set
			{
				if (_statFlagDefensiveState == value)
				{
					return;
				}
				_statFlagDefensiveState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("prevNPCStanceState")] 
		public CEnum<gamedataNPCStanceState> PrevNPCStanceState
		{
			get
			{
				if (_prevNPCStanceState == null)
				{
					_prevNPCStanceState = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "prevNPCStanceState", cr2w, this);
				}
				return _prevNPCStanceState;
			}
			set
			{
				if (_prevNPCStanceState == value)
				{
					return;
				}
				_prevNPCStanceState = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("previousHighLevelState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousHighLevelState
		{
			get
			{
				if (_previousHighLevelState == null)
				{
					_previousHighLevelState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "previousHighLevelState", cr2w, this);
				}
				return _previousHighLevelState;
			}
			set
			{
				if (_previousHighLevelState == value)
				{
					return;
				}
				_previousHighLevelState = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("prevHitReactionMode")] 
		public CEnum<EHitReactionMode> PrevHitReactionMode
		{
			get
			{
				if (_prevHitReactionMode == null)
				{
					_prevHitReactionMode = (CEnum<EHitReactionMode>) CR2WTypeManager.Create("EHitReactionMode", "prevHitReactionMode", cr2w, this);
				}
				return _prevHitReactionMode;
			}
			set
			{
				if (_prevHitReactionMode == value)
				{
					return;
				}
				_prevHitReactionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bulkyStaggerMinRecordID")] 
		public TweakDBID BulkyStaggerMinRecordID
		{
			get
			{
				if (_bulkyStaggerMinRecordID == null)
				{
					_bulkyStaggerMinRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bulkyStaggerMinRecordID", cr2w, this);
				}
				return _bulkyStaggerMinRecordID;
			}
			set
			{
				if (_bulkyStaggerMinRecordID == value)
				{
					return;
				}
				_bulkyStaggerMinRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("staggerMinRecordID")] 
		public TweakDBID StaggerMinRecordID
		{
			get
			{
				if (_staggerMinRecordID == null)
				{
					_staggerMinRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "staggerMinRecordID", cr2w, this);
				}
				return _staggerMinRecordID;
			}
			set
			{
				if (_staggerMinRecordID == value)
				{
					return;
				}
				_staggerMinRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("unstoppableRecordID")] 
		public TweakDBID UnstoppableRecordID
		{
			get
			{
				if (_unstoppableRecordID == null)
				{
					_unstoppableRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "unstoppableRecordID", cr2w, this);
				}
				return _unstoppableRecordID;
			}
			set
			{
				if (_unstoppableRecordID == value)
				{
					return;
				}
				_unstoppableRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("unstoppableTwitchMinRecordID")] 
		public TweakDBID UnstoppableTwitchMinRecordID
		{
			get
			{
				if (_unstoppableTwitchMinRecordID == null)
				{
					_unstoppableTwitchMinRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "unstoppableTwitchMinRecordID", cr2w, this);
				}
				return _unstoppableTwitchMinRecordID;
			}
			set
			{
				if (_unstoppableTwitchMinRecordID == value)
				{
					return;
				}
				_unstoppableTwitchMinRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("unstoppableTwitchNoneRecordID")] 
		public TweakDBID UnstoppableTwitchNoneRecordID
		{
			get
			{
				if (_unstoppableTwitchNoneRecordID == null)
				{
					_unstoppableTwitchNoneRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "unstoppableTwitchNoneRecordID", cr2w, this);
				}
				return _unstoppableTwitchNoneRecordID;
			}
			set
			{
				if (_unstoppableTwitchNoneRecordID == value)
				{
					return;
				}
				_unstoppableTwitchNoneRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("forceImpactRecordID")] 
		public TweakDBID ForceImpactRecordID
		{
			get
			{
				if (_forceImpactRecordID == null)
				{
					_forceImpactRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "forceImpactRecordID", cr2w, this);
				}
				return _forceImpactRecordID;
			}
			set
			{
				if (_forceImpactRecordID == value)
				{
					return;
				}
				_forceImpactRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("forceStaggerRecordID")] 
		public TweakDBID ForceStaggerRecordID
		{
			get
			{
				if (_forceStaggerRecordID == null)
				{
					_forceStaggerRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "forceStaggerRecordID", cr2w, this);
				}
				return _forceStaggerRecordID;
			}
			set
			{
				if (_forceStaggerRecordID == value)
				{
					return;
				}
				_forceStaggerRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("forceKnockdownRecordID")] 
		public TweakDBID ForceKnockdownRecordID
		{
			get
			{
				if (_forceKnockdownRecordID == null)
				{
					_forceKnockdownRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "forceKnockdownRecordID", cr2w, this);
				}
				return _forceKnockdownRecordID;
			}
			set
			{
				if (_forceKnockdownRecordID == value)
				{
					return;
				}
				_forceKnockdownRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("fragileRecordID")] 
		public TweakDBID FragileRecordID
		{
			get
			{
				if (_fragileRecordID == null)
				{
					_fragileRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "fragileRecordID", cr2w, this);
				}
				return _fragileRecordID;
			}
			set
			{
				if (_fragileRecordID == value)
				{
					return;
				}
				_fragileRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("weakRecordID")] 
		public TweakDBID WeakRecordID
		{
			get
			{
				if (_weakRecordID == null)
				{
					_weakRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weakRecordID", cr2w, this);
				}
				return _weakRecordID;
			}
			set
			{
				if (_weakRecordID == value)
				{
					return;
				}
				_weakRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("toughRecordID")] 
		public TweakDBID ToughRecordID
		{
			get
			{
				if (_toughRecordID == null)
				{
					_toughRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "toughRecordID", cr2w, this);
				}
				return _toughRecordID;
			}
			set
			{
				if (_toughRecordID == value)
				{
					return;
				}
				_toughRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("bulkyRecordID")] 
		public TweakDBID BulkyRecordID
		{
			get
			{
				if (_bulkyRecordID == null)
				{
					_bulkyRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bulkyRecordID", cr2w, this);
				}
				return _bulkyRecordID;
			}
			set
			{
				if (_bulkyRecordID == value)
				{
					return;
				}
				_bulkyRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("regularRecordID")] 
		public TweakDBID RegularRecordID
		{
			get
			{
				if (_regularRecordID == null)
				{
					_regularRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "regularRecordID", cr2w, this);
				}
				return _regularRecordID;
			}
			set
			{
				if (_regularRecordID == value)
				{
					return;
				}
				_regularRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get
			{
				if (_inCombat == null)
				{
					_inCombat = (CBool) CR2WTypeManager.Create("Bool", "inCombat", cr2w, this);
				}
				return _inCombat;
			}
			set
			{
				if (_inCombat == value)
				{
					return;
				}
				_inCombat = value;
				PropertySet(this);
			}
		}

		public NPCStatesComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
