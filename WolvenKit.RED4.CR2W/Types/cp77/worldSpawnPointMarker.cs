using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpawnPointMarker : worldIMarker
	{
		[Ordinal(0)] [RED("type")] public CUInt32 Type { get; set; }

		public worldSpawnPointMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
