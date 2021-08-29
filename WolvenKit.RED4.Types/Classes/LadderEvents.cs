using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LadderEvents : LocomotionGroundEvents
	{
		private CFloat _ladderClimbCameraTimeStamp;

		[Ordinal(3)] 
		[RED("ladderClimbCameraTimeStamp")] 
		public CFloat LadderClimbCameraTimeStamp
		{
			get => GetProperty(ref _ladderClimbCameraTimeStamp);
			set => SetProperty(ref _ladderClimbCameraTimeStamp, value);
		}
	}
}
