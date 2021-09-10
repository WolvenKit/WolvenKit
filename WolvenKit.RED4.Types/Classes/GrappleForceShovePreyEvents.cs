using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleForceShovePreyEvents : LocomotionTakedownEvents
	{
		[Ordinal(4)] 
		[RED("unmountCalled")] 
		public CBool UnmountCalled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
