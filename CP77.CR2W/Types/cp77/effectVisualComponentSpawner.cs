using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectVisualComponentSpawner : effectSpawner
	{
		[Ordinal(0)] [RED("componentName")] public CArray<CName> ComponentName { get; set; }

		public effectVisualComponentSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
