using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		private CBool _unmountCalled;

		[Ordinal(4)] 
		[RED("unmountCalled")] 
		public CBool UnmountCalled
		{
			get => GetProperty(ref _unmountCalled);
			set => SetProperty(ref _unmountCalled, value);
		}
	}
}
