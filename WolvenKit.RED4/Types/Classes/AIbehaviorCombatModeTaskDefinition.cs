using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorCombatModeTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<AIbehaviorCombatModes> Mode
		{
			get => GetPropertyValue<CEnum<AIbehaviorCombatModes>>();
			set => SetPropertyValue<CEnum<AIbehaviorCombatModes>>(value);
		}

		[Ordinal(2)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AIbehaviorCombatModeTaskDefinition()
		{
			TimeToLive = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
