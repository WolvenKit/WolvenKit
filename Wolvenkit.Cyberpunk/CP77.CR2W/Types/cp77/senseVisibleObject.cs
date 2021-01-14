using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObject : IScriptable
	{
		[Ordinal(0)]  [RED("description")] public CName Description { get; set; }
		[Ordinal(1)]  [RED("visibilityDistance")] public CFloat VisibilityDistance { get; set; }
		[Ordinal(2)]  [RED("visibleObjectType")] public CEnum<gamedataSenseObjectType> VisibleObjectType { get; set; }

		public senseVisibleObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
