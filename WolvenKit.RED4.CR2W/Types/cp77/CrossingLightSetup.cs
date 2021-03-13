using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLightSetup : CVariable
	{
		[Ordinal(0)] [RED("greenLightSFX")] public CName GreenLightSFX { get; set; }
		[Ordinal(1)] [RED("redLightSFX")] public CName RedLightSFX { get; set; }

		public CrossingLightSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
