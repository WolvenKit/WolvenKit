using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JumpDecisions : LocomotionAirDecisions
	{
		private CBool _jumpPressed;

		[Ordinal(3)] 
		[RED("jumpPressed")] 
		public CBool JumpPressed
		{
			get => GetProperty(ref _jumpPressed);
			set => SetProperty(ref _jumpPressed, value);
		}
	}
}
