using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorWidgetCustomData : WidgetCustomData
	{
		[Ordinal(0)] [RED("passcode")] public CInt32 Passcode { get; set; }
		[Ordinal(1)] [RED("card")] public CName Card { get; set; }
		[Ordinal(2)] [RED("isPasswordKnown")] public CBool IsPasswordKnown { get; set; }

		public DoorWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
