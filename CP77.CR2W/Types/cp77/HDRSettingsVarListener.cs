using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HDRSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] [RED("ctrl")] public wCHandle<gameuiHDRSettingsGameController> Ctrl { get; set; }

		public HDRSettingsVarListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
