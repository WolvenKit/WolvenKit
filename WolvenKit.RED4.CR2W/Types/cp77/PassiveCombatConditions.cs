using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCombatConditions : PassiveAutonomousCondition
	{
		private CUInt32 _combatCommandCbId;
		private CUInt32 _roleCbId;
		private CUInt32 _threatCbId;
		private CUInt32 _playerCombatCbId;
		private CUInt32 _activeCombatConditionCbId;
		private CUInt32 _delayEvaluationCbId;

		[Ordinal(0)] 
		[RED("combatCommandCbId")] 
		public CUInt32 CombatCommandCbId
		{
			get
			{
				if (_combatCommandCbId == null)
				{
					_combatCommandCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "combatCommandCbId", cr2w, this);
				}
				return _combatCommandCbId;
			}
			set
			{
				if (_combatCommandCbId == value)
				{
					return;
				}
				_combatCommandCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get
			{
				if (_roleCbId == null)
				{
					_roleCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "roleCbId", cr2w, this);
				}
				return _roleCbId;
			}
			set
			{
				if (_roleCbId == value)
				{
					return;
				}
				_roleCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("threatCbId")] 
		public CUInt32 ThreatCbId
		{
			get
			{
				if (_threatCbId == null)
				{
					_threatCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "threatCbId", cr2w, this);
				}
				return _threatCbId;
			}
			set
			{
				if (_threatCbId == value)
				{
					return;
				}
				_threatCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerCombatCbId")] 
		public CUInt32 PlayerCombatCbId
		{
			get
			{
				if (_playerCombatCbId == null)
				{
					_playerCombatCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "playerCombatCbId", cr2w, this);
				}
				return _playerCombatCbId;
			}
			set
			{
				if (_playerCombatCbId == value)
				{
					return;
				}
				_playerCombatCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activeCombatConditionCbId")] 
		public CUInt32 ActiveCombatConditionCbId
		{
			get
			{
				if (_activeCombatConditionCbId == null)
				{
					_activeCombatConditionCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "activeCombatConditionCbId", cr2w, this);
				}
				return _activeCombatConditionCbId;
			}
			set
			{
				if (_activeCombatConditionCbId == value)
				{
					return;
				}
				_activeCombatConditionCbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get
			{
				if (_delayEvaluationCbId == null)
				{
					_delayEvaluationCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "delayEvaluationCbId", cr2w, this);
				}
				return _delayEvaluationCbId;
			}
			set
			{
				if (_delayEvaluationCbId == value)
				{
					return;
				}
				_delayEvaluationCbId = value;
				PropertySet(this);
			}
		}

		public PassiveCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
