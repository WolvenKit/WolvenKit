using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineParams : questAICommandParams
	{
		private NodeRef _splineNodeRef;
		private CBool _useStart;
		private CBool _useStop;
		private CBool _reverse;
		private CBool _startFromClosestPoint;
		private CHandle<questMoveOnSplineAdditionalParams> _additionalParams;
		private CBool _useAlertedState;
		private CBool _useCombatState;
		private CBool _executeWhileDespawned;
		private CBool _repeatCommandOnInterrupt;
		private CFloat _noWaitToEndDistance;
		private CFloat _noWaitToEndCompanionDistance;
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(0)] 
		[RED("splineNodeRef")] 
		public NodeRef SplineNodeRef
		{
			get
			{
				if (_splineNodeRef == null)
				{
					_splineNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineNodeRef", cr2w, this);
				}
				return _splineNodeRef;
			}
			set
			{
				if (_splineNodeRef == value)
				{
					return;
				}
				_splineNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CBool) CR2WTypeManager.Create("Bool", "useStart", cr2w, this);
				}
				return _useStart;
			}
			set
			{
				if (_useStart == value)
				{
					return;
				}
				_useStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CBool) CR2WTypeManager.Create("Bool", "useStop", cr2w, this);
				}
				return _useStop;
			}
			set
			{
				if (_useStop == value)
				{
					return;
				}
				_useStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CBool) CR2WTypeManager.Create("Bool", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CBool) CR2WTypeManager.Create("Bool", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("additionalParams")] 
		public CHandle<questMoveOnSplineAdditionalParams> AdditionalParams
		{
			get
			{
				if (_additionalParams == null)
				{
					_additionalParams = (CHandle<questMoveOnSplineAdditionalParams>) CR2WTypeManager.Create("handle:questMoveOnSplineAdditionalParams", "additionalParams", cr2w, this);
				}
				return _additionalParams;
			}
			set
			{
				if (_additionalParams == value)
				{
					return;
				}
				_additionalParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get
			{
				if (_useAlertedState == null)
				{
					_useAlertedState = (CBool) CR2WTypeManager.Create("Bool", "useAlertedState", cr2w, this);
				}
				return _useAlertedState;
			}
			set
			{
				if (_useAlertedState == value)
				{
					return;
				}
				_useAlertedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get
			{
				if (_useCombatState == null)
				{
					_useCombatState = (CBool) CR2WTypeManager.Create("Bool", "useCombatState", cr2w, this);
				}
				return _useCombatState;
			}
			set
			{
				if (_useCombatState == value)
				{
					return;
				}
				_useCombatState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get
			{
				if (_executeWhileDespawned == null)
				{
					_executeWhileDespawned = (CBool) CR2WTypeManager.Create("Bool", "executeWhileDespawned", cr2w, this);
				}
				return _executeWhileDespawned;
			}
			set
			{
				if (_executeWhileDespawned == value)
				{
					return;
				}
				_executeWhileDespawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get
			{
				if (_noWaitToEndDistance == null)
				{
					_noWaitToEndDistance = (CFloat) CR2WTypeManager.Create("Float", "noWaitToEndDistance", cr2w, this);
				}
				return _noWaitToEndDistance;
			}
			set
			{
				if (_noWaitToEndDistance == value)
				{
					return;
				}
				_noWaitToEndDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get
			{
				if (_noWaitToEndCompanionDistance == null)
				{
					_noWaitToEndCompanionDistance = (CFloat) CR2WTypeManager.Create("Float", "noWaitToEndCompanionDistance", cr2w, this);
				}
				return _noWaitToEndCompanionDistance;
			}
			set
			{
				if (_noWaitToEndCompanionDistance == value)
				{
					return;
				}
				_noWaitToEndCompanionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get
			{
				if (_removeAfterCombat == null)
				{
					_removeAfterCombat = (CBool) CR2WTypeManager.Create("Bool", "removeAfterCombat", cr2w, this);
				}
				return _removeAfterCombat;
			}
			set
			{
				if (_removeAfterCombat == value)
				{
					return;
				}
				_removeAfterCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get
			{
				if (_ignoreInCombat == null)
				{
					_ignoreInCombat = (CBool) CR2WTypeManager.Create("Bool", "ignoreInCombat", cr2w, this);
				}
				return _ignoreInCombat;
			}
			set
			{
				if (_ignoreInCombat == value)
				{
					return;
				}
				_ignoreInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get
			{
				if (_alwaysUseStealth == null)
				{
					_alwaysUseStealth = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseStealth", cr2w, this);
				}
				return _alwaysUseStealth;
			}
			set
			{
				if (_alwaysUseStealth == value)
				{
					return;
				}
				_alwaysUseStealth = value;
				PropertySet(this);
			}
		}

		public questMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
