using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightControllerPS : TrafficLightControllerPS
	{
		[Ordinal(103)] [RED("crossingLightSFXSetup")] public CrossingLightSetup CrossingLightSFXSetup { get; set; }

		public CrossingLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
