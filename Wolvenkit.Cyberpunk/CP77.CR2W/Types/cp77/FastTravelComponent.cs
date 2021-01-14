using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("fastTravelNodes")] public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes { get; set; }

		public FastTravelComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
