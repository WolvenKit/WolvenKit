using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTaggedSignalUserData : gameSignalUserData
	{
		[Ordinal(0)] [RED("tags")] public CArray<CName> Tags { get; set; }

		public gameTaggedSignalUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
