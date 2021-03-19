using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AbstractLandEvents : LocomotionGroundEvents
	{
		private CBool _blockLandingStimBroadcasting;

		[Ordinal(0)] 
		[RED("blockLandingStimBroadcasting")] 
		public CBool BlockLandingStimBroadcasting
		{
			get => GetProperty(ref _blockLandingStimBroadcasting);
			set => SetProperty(ref _blockLandingStimBroadcasting, value);
		}

		public AbstractLandEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
