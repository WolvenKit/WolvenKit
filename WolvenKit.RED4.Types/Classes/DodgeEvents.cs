using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DodgeEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(7)] 
		[RED("decelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(8)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DodgeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
