using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(0)]  [RED("factQuickHackSetup")] public ComputerQuickHackData FactQuickHackSetup { get; set; }
		[Ordinal(1)]  [RED("quickhackPerformed")] public CBool QuickhackPerformed { get; set; }

		public NetrunnerControlPanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
