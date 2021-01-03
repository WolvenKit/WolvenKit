using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshChunkFlags : CVariable
	{
		[Ordinal(0)]  [RED("isRayTracedEmissive")] public CBool IsRayTracedEmissive { get; set; }
		[Ordinal(1)]  [RED("isTwoSided")] public CBool IsTwoSided { get; set; }
		[Ordinal(2)]  [RED("renderInScene")] public CBool RenderInScene { get; set; }
		[Ordinal(3)]  [RED("renderInShadows")] public CBool RenderInShadows { get; set; }

		public meshChunkFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
