using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(108)] [RED("factName")] public ComputerQuickHackData FactName { get; set; }

		public MainframeControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
