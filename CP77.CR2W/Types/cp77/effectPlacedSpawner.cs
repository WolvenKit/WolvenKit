using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectPlacedSpawner : effectSpawner
	{
		[Ordinal(0)]  [RED("placement")] public CHandle<effectIPlacementEntries> Placement { get; set; }

		public effectPlacedSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
