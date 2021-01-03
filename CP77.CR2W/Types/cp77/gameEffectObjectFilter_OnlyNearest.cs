using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearest : gameEffectObjectGroupFilter
	{
		[Ordinal(0)]  [RED("count")] public CUInt32 Count { get; set; }

		public gameEffectObjectFilter_OnlyNearest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
