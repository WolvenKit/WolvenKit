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
			get => GetProperty(ref _highLevelStates);
			set => SetProperty(ref _highLevelStates, value);
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamedataNPCUpperBodyState>> UpperBodyStates
		{
			get => GetProperty(ref _upperBodyStates);
			set => SetProperty(ref _upperBodyStates, value);
		}

		[Ordinal(2)] 
		[RED("stanceStates")] 
		public CArray<CEnum<gamedataNPCStanceState>> StanceStates
		{
			get => GetProperty(ref _stanceStates);
			set => SetProperty(ref _stanceStates, value);
		}

		[Ordinal(3)] 
		[RED("behaviorStates")] 
		public CArray<CEnum<gamedataNPCBehaviorState>> BehaviorStates
		{
			get => GetProperty(ref _behaviorStates);
			set => SetProperty(ref _behaviorStates, value);
		}

		[Ordinal(4)] 
		[RED("defenseMode")] 
		public CArray<CEnum<gamedataDefenseMode>> DefenseMode
		{
			get => GetProperty(ref _defenseMode);
			set => SetProperty(ref _defenseMode, value);
		}

		[Ordinal(5)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get => GetProperty(ref _locomotionMode);
			set => SetProperty(ref _locomotionMode, value);
		}

		public AIActionNPCStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
