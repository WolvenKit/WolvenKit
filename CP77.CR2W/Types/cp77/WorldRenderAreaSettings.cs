using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldRenderAreaSettings : CVariable
	{
		[Ordinal(0)] [RED("areaParameters")] public CArray<CHandle<IAreaSettings>> AreaParameters { get; set; }

		public WorldRenderAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
