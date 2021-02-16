using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObjectComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("visibleObject")] public CHandle<senseVisibleObject> VisibleObject { get; set; }

		public senseVisibleObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
