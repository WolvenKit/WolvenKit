using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("factQuickHackSetup")] public ComputerQuickHackData FactQuickHackSetup { get; set; }
		[Ordinal(109)] [RED("quickhackPerformed")] public CBool QuickhackPerformed { get; set; }

		public NetrunnerControlPanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
