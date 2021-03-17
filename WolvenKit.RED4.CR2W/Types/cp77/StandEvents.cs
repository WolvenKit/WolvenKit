using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StandEvents : LocomotionGroundEvents
	{
		private CFloat _previousStimTimeStamp;

		[Ordinal(0)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get => GetProperty(ref _previousStimTimeStamp);
			set => SetProperty(ref _previousStimTimeStamp, value);
		}

		public StandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
