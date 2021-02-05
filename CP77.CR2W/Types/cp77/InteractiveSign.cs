using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveSign : Device
	{
		[Ordinal(77)]  [RED("signShape")] public CEnum<SignShape> SignShape { get; set; }
		[Ordinal(78)]  [RED("type")] public CEnum<SignType> Type { get; set; }
		[Ordinal(79)]  [RED("message")] public CString Message { get; set; }

		public InteractiveSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
