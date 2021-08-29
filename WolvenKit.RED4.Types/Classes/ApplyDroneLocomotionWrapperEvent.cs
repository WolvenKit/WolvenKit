using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyDroneLocomotionWrapperEvent : redEvent
	{
		private CName _movementType;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}
	}
}
