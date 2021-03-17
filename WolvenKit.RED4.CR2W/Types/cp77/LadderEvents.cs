using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LadderEvents : LocomotionGroundEvents
	{
		private CFloat _ladderClimbCameraTimeStamp;

		[Ordinal(0)] 
		[RED("ladderClimbCameraTimeStamp")] 
		public CFloat LadderClimbCameraTimeStamp
		{
			get => GetProperty(ref _ladderClimbCameraTimeStamp);
			set => SetProperty(ref _ladderClimbCameraTimeStamp, value);
		}

		public LadderEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
