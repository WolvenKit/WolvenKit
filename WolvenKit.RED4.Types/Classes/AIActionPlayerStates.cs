using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionPlayerStates : RedBaseClass
	{
		private CArray<CEnum<gamePSMLocomotionStates>> _locomotionStates;
		private CArray<CEnum<gamePSMUpperBodyStates>> _upperBodyStates;
		private CArray<CEnum<gamePSMMelee>> _meleeStates;
		private CArray<CEnum<gamePSMZones>> _zoneStates;
		private CArray<CEnum<gamePSMBodyCarrying>> _bodyCarryStates;
		private CArray<CEnum<gamePSMCombat>> _combatStates;

		[Ordinal(0)] 
		[RED("locomotionStates")] 
		public CArray<CEnum<gamePSMLocomotionStates>> LocomotionStates
		{
			get => GetProperty(ref _locomotionStates);
			set => SetProperty(ref _locomotionStates, value);
		}

		[Ordinal(1)] 
		[RED("upperBodyStates")] 
		public CArray<CEnum<gamePSMUpperBodyStates>> UpperBodyStates
		{
			get => GetProperty(ref _upperBodyStates);
			set => SetProperty(ref _upperBodyStates, value);
		}

		[Ordinal(2)] 
		[RED("meleeStates")] 
		public CArray<CEnum<gamePSMMelee>> MeleeStates
		{
			get => GetProperty(ref _meleeStates);
			set => SetProperty(ref _meleeStates, value);
		}

		[Ordinal(3)] 
		[RED("zoneStates")] 
		public CArray<CEnum<gamePSMZones>> ZoneStates
		{
			get => GetProperty(ref _zoneStates);
			set => SetProperty(ref _zoneStates, value);
		}

		[Ordinal(4)] 
		[RED("bodyCarryStates")] 
		public CArray<CEnum<gamePSMBodyCarrying>> BodyCarryStates
		{
			get => GetProperty(ref _bodyCarryStates);
			set => SetProperty(ref _bodyCarryStates, value);
		}

		[Ordinal(5)] 
		[RED("combatStates")] 
		public CArray<CEnum<gamePSMCombat>> CombatStates
		{
			get => GetProperty(ref _combatStates);
			set => SetProperty(ref _combatStates, value);
		}
	}
}
