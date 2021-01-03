using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Climbable : worldEditorDebugColoringSettings
	{
		[Ordinal(0)]  [RED("climbableColour")] public CColor ClimbableColour { get; set; }
		[Ordinal(1)]  [RED("notClimbableColour")] public CColor NotClimbableColour { get; set; }

		public worldDebugColoring_Climbable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
