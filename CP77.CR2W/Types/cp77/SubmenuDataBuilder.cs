using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SubmenuDataBuilder : IScriptable
	{
		[Ordinal(0)]  [RED("menuBuilder")] public CHandle<MenuDataBuilder> MenuBuilder { get; set; }
		[Ordinal(1)]  [RED("menuDataIndex")] public CInt32 MenuDataIndex { get; set; }

		public SubmenuDataBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
