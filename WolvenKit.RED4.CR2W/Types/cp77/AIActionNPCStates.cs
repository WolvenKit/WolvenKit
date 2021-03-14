using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionNPCStates : CVariable
	{
		private CArray<CEnum<gamedataNPCHighLevelState>> _highLevelStates;
		private CArray<CEnum<gamedataNPCUpperBodyState>> _upperBodyStates;
		private CArray<CEnum<gamedataNPCStanceState>> _stanceStates;
		private CArray<CEnum<gamedataNPCBehaviorState>> _behaviorStates;
		private CArray<CEnum<gamedataDefenseMode>> _defenseMode;
		private CArray<CEnum<gamedataLocomotionMode>> _locomotionMode;

		[Ordinal(0)] 
		[RED("highLevelStates")] 
		public CArray<CEnum<gamedataNPCHighLevelState>> HighLevelStates
		{
			get
			{
				if (_highLevelStates == null)
				{
					_highLevelStates = (CArray<CEnum<gamedataNPCHighLevelState>>) CR2WTypeManager.Create("array:gamedataNPCHighLevelState", "highLevelStates", cr2w, this);
				}
				return _highLevelStates;
			}
			set
			{
				if (_highLevelStates == value)
				{
					return;
				}
				_highLevelStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamedataNPCUpperBodyState>> UpperBodyStates
		{
			get
			{
				if (_upperBodyStates == null)
				{
					_upperBodyStates = (CArray<CEnum<gamedataNPCUpperBodyState>>) CR2WTypeManager.Create("array:gamedataNPCUpperBodyState", "upperBodyStates", cr2w, this);
				}
				return _upperBodyStates;
			}
			set
			{
				if (_upperBodyStates == value)
				{
					return;
				}
				_upperBodyStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stanceStates")] 
		public CArray<CEnum<gamedataNPCStanceState>> StanceStates
		{
			get
			{
				if (_stanceStates == null)
				{
					_stanceStates = (CArray<CEnum<gamedataNPCStanceState>>) CR2WTypeManager.Create("array:gamedataNPCStanceState", "stanceStates", cr2w, this);
				}
				return _stanceStates;
			}
			set
			{
				if (_stanceStates == value)
				{
					return;
				}
				_stanceStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("behaviorStates")] 
		public CArray<CEnum<gamedataNPCBehaviorState>> BehaviorStates
		{
			get
			{
				if (_behaviorStates == null)
				{
					_behaviorStates = (CArray<CEnum<gamedataNPCBehaviorState>>) CR2WTypeManager.Create("array:gamedataNPCBehaviorState", "behaviorStates", cr2w, this);
				}
				return _behaviorStates;
			}
			set
			{
				if (_behaviorStates == value)
				{
					return;
				}
				_behaviorStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("defenseMode")] 
		public CArray<CEnum<gamedataDefenseMode>> DefenseMode
		{
			get
			{
				if (_defenseMode == null)
				{
					_defenseMode = (CArray<CEnum<gamedataDefenseMode>>) CR2WTypeManager.Create("array:gamedataDefenseMode", "defenseMode", cr2w, this);
				}
				return _defenseMode;
			}
			set
			{
				if (_defenseMode == value)
				{
					return;
				}
				_defenseMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get
			{
				if (_locomotionMode == null)
				{
					_locomotionMode = (CArray<CEnum<gamedataLocomotionMode>>) CR2WTypeManager.Create("array:gamedataLocomotionMode", "locomotionMode", cr2w, this);
				}
				return _locomotionMode;
			}
			set
			{
				if (_locomotionMode == value)
				{
					return;
				}
				_locomotionMode = value;
				PropertySet(this);
			}
		}

		public AIActionNPCStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
