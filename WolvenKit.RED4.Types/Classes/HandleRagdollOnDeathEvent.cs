using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HandleRagdollOnDeathEvent : redEvent
	{
		private CBool _handleUncontrolledMovement;

		[Ordinal(0)] 
		[RED("handleUncontrolledMovement")] 
		public CBool HandleUncontrolledMovement
		{
			get => GetProperty(ref _handleUncontrolledMovement);
			set => SetProperty(ref _handleUncontrolledMovement, value);
		}
	}
}
