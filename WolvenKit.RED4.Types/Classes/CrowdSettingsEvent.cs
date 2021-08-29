using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrowdSettingsEvent : redEvent
	{
		private CName _movementType;
		private CBool _resetFear;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("resetFear")] 
		public CBool ResetFear
		{
			get => GetProperty(ref _resetFear);
			set => SetProperty(ref _resetFear, value);
		}
	}
}
