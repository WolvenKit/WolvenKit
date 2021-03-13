using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettings : CVariable
	{
		[Ordinal(0)] [RED("openEvent")] public CName OpenEvent { get; set; }
		[Ordinal(1)] [RED("closeEvent")] public CName CloseEvent { get; set; }

		public audioVehicleDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
