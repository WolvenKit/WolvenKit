using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrappleStandEvents : LocomotionTakedownEvents
	{
		[Ordinal(7)] 
		[RED("isWalking")] 
		public CBool IsWalking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
