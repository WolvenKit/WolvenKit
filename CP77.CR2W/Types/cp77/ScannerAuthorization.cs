using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerAuthorization : ScannerChunk
	{
		[Ordinal(0)] [RED("keycard")] public CBool Keycard { get; set; }
		[Ordinal(1)] [RED("password")] public CBool Password { get; set; }

		public ScannerAuthorization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
