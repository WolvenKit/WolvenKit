using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameaudioAcousticPortalComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("initialyOpen")] public CBool InitialyOpen { get; set; }
		[Ordinal(1)]  [RED("nominalRadius")] public CUInt8 NominalRadius { get; set; }
		[Ordinal(2)]  [RED("radius")] public CUInt8 Radius { get; set; }

		public gameaudioAcousticPortalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
