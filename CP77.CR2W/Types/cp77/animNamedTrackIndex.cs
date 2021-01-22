using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animNamedTrackIndex : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }

		public animNamedTrackIndex(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
