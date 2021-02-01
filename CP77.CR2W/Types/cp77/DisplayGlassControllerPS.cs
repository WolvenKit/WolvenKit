using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisplayGlassControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("clearAppearance")] public CName ClearAppearance { get; set; }
		[Ordinal(1)]  [RED("isTinted")] public CBool IsTinted { get; set; }
		[Ordinal(2)]  [RED("tintedAppearance")] public CName TintedAppearance { get; set; }
		[Ordinal(3)]  [RED("useAppearances")] public CBool UseAppearances { get; set; }

		public DisplayGlassControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
