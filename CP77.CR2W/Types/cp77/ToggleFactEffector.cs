using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleFactEffector : gameEffector
	{
		[Ordinal(0)] [RED("fact")] public CName Fact { get; set; }
		[Ordinal(1)] [RED("valueOn")] public CInt32 ValueOn { get; set; }
		[Ordinal(2)] [RED("valueOff")] public CInt32 ValueOff { get; set; }

		public ToggleFactEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
