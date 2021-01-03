using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendSLightFlickering : CVariable
	{
		[Ordinal(0)]  [RED("flickerPeriod")] public CFloat FlickerPeriod { get; set; }
		[Ordinal(1)]  [RED("flickerStrength")] public CFloat FlickerStrength { get; set; }
		[Ordinal(2)]  [RED("positionOffset")] public CFloat PositionOffset { get; set; }

		public rendSLightFlickering(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
