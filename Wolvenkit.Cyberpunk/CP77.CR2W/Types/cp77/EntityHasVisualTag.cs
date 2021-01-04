using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EntityHasVisualTag : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("hasTag")] public CBool HasTag { get; set; }
		[Ordinal(1)]  [RED("visualTag")] public CName VisualTag { get; set; }

		public EntityHasVisualTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
