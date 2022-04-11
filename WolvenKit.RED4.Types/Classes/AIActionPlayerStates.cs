using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIActionPlayerStates : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("locomotionStates")] 
		public CArray<CEnum<gamePSMLocomotionStates>> LocomotionStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMLocomotionStates>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMLocomotionStates>>>(value);
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamePSMUpperBodyStates>> UpperBodyStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMUpperBodyStates>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMUpperBodyStates>>>(value);
		}

		[Ordinal(2)] 
		[RED("meleeStates")] 
		public CArray<CEnum<gamePSMMelee>> MeleeStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMMelee>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMMelee>>>(value);
		}

		[Ordinal(3)] 
		[RED("zoneStates")] 
		public CArray<CEnum<gamePSMZones>> ZoneStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMZones>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMZones>>>(value);
		}

		[Ordinal(4)] 
		[RED("bodyCarryStates")] 
		public CArray<CEnum<gamePSMBodyCarrying>> BodyCarryStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMBodyCarrying>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMBodyCarrying>>>(value);
		}

		[Ordinal(5)] 
		[RED("combatStates")] 
		public CArray<CEnum<gamePSMCombat>> CombatStates
		{
			get => GetPropertyValue<CArray<CEnum<gamePSMCombat>>>();
			set => SetPropertyValue<CArray<CEnum<gamePSMCombat>>>(value);
		}

		public AIActionPlayerStates()
		{
			LocomotionStates = new();
			UpperBodyStates = new();
			MeleeStates = new();
			ZoneStates = new();
			BodyCarryStates = new();
			CombatStates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
