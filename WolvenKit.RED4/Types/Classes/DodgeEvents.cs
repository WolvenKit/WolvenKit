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
		[RED("dashDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DashDecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(8)] 
		[RED("airDashDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AirDashDecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(9)] 
		[RED("currentNumberOfJumps")] 
		public CInt32 CurrentNumberOfJumps
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("crouching")] 
		public CBool Crouching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("enteredFromSlide")] 
		public CBool EnteredFromSlide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isAirDashSaveLockTriggered")] 
		public CBool IsAirDashSaveLockTriggered
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
