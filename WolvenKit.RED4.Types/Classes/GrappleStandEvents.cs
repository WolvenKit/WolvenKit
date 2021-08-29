using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleStandEvents : LocomotionTakedownEvents
	{
		private CBool _isWalking;

		[Ordinal(4)] 
		[RED("isWalking")] 
		public CBool IsWalking
		{
			get => GetProperty(ref _isWalking);
			set => SetProperty(ref _isWalking, value);
		}
	}
}
