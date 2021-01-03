using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectVisualComponentSpawner : effectSpawner
	{
		[Ordinal(0)]  [RED("componentName")] public CArray<CName> ComponentName { get; set; }

		public effectVisualComponentSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
