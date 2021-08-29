using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DodgeEvents : LocomotionGroundEvents
	{
		private CHandle<gameStatModifierData_Deprecated> _blockStatFlag;
		private CHandle<gameStatModifierData_Deprecated> _decelerationModifier;
		private CBool _pressureWaveCreated;

		[Ordinal(3)] 
		[RED("blockStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> BlockStatFlag
		{
			get => GetProperty(ref _blockStatFlag);
			set => SetProperty(ref _blockStatFlag, value);
		}

		[Ordinal(4)] 
		[RED("decelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> DecelerationModifier
		{
			get => GetProperty(ref _decelerationModifier);
			set => SetProperty(ref _decelerationModifier, value);
		}

		[Ordinal(5)] 
		[RED("pressureWaveCreated")] 
		public CBool PressureWaveCreated
		{
			get => GetProperty(ref _pressureWaveCreated);
			set => SetProperty(ref _pressureWaveCreated, value);
		}
	}
}
