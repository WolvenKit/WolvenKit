using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameTime : CVariable
	{
		[Ordinal(0)]  [RED("seconds")] public CInt32 Seconds { get; set; }

		public GameTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
