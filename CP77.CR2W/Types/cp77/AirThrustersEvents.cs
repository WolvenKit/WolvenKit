using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AirThrustersEvents : LocomotionAirEvents
	{
		[Ordinal(0)]  [RED("maxSuperheroFallHeight")] public CBool MaxSuperheroFallHeight { get; set; }
		[Ordinal(1)]  [RED("updateInputToggles")] public CBool UpdateInputToggles { get; set; }

		public AirThrustersEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
