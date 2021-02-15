using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CommandSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] [RED("track")] public CBool Track { get; set; }
		[Ordinal(2)] [RED("commandClassNames")] public CArray<CName> CommandClassNames { get; set; }

		public CommandSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
