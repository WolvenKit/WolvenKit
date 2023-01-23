using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionNPCStates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("highLevelStates")] 
		public CArray<CEnum<gamedataNPCHighLevelState>> HighLevelStates
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNPCHighLevelState>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNPCHighLevelState>>>(value);
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamedataNPCUpperBodyState>> UpperBodyStates
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNPCUpperBodyState>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNPCUpperBodyState>>>(value);
		}

		[Ordinal(2)] 
		[RED("stanceStates")] 
		public CArray<CEnum<gamedataNPCStanceState>> StanceStates
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNPCStanceState>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNPCStanceState>>>(value);
		}

		[Ordinal(3)] 
		[RED("behaviorStates")] 
		public CArray<CEnum<gamedataNPCBehaviorState>> BehaviorStates
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNPCBehaviorState>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNPCBehaviorState>>>(value);
		}

		[Ordinal(4)] 
		[RED("defenseMode")] 
		public CArray<CEnum<gamedataDefenseMode>> DefenseMode
		{
			get => GetPropertyValue<CArray<CEnum<gamedataDefenseMode>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataDefenseMode>>>(value);
		}

		[Ordinal(5)] 
		[RED("locomotionMode")] 
		public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode
		{
			get => GetPropertyValue<CArray<CEnum<gamedataLocomotionMode>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataLocomotionMode>>>(value);
		}

		public AIActionNPCStates()
		{
			HighLevelStates = new();
			UpperBodyStates = new();
			StanceStates = new();
			BehaviorStates = new();
			DefenseMode = new();
			LocomotionMode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
