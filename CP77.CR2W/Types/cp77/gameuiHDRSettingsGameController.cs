using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiHDRSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("callibrationScreen")] public rRef<CBitmapTexture> CallibrationScreen { get; set; }
		[Ordinal(1)]  [RED("callibrationScreenAtlas")] public raRef<inkTextureAtlas> CallibrationScreenAtlas { get; set; }
		[Ordinal(2)]  [RED("callibrationScreenTarget")] public inkWidgetReference CallibrationScreenTarget { get; set; }

		public gameuiHDRSettingsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
