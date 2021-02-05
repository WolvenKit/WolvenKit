using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponent : gameComponent
	{
		[Ordinal(0)]  [RED("availableVisionModes")] public CArray<gameVisionModuleParams> AvailableVisionModes { get; set; }

		public gameVisionModeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
