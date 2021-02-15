using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SGenericDeviceActionsData : CVariable
	{
		[Ordinal(0)] [RED("toggleON")] public SDeviceActionBoolData ToggleON { get; set; }
		[Ordinal(1)] [RED("togglePower")] public SDeviceActionBoolData TogglePower { get; set; }

		public SGenericDeviceActionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
