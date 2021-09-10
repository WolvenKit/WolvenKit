using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderEvents : LocomotionGroundEvents
	{
		[Ordinal(3)] 
		[RED("ladderClimbCameraTimeStamp")] 
		public CFloat LadderClimbCameraTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
