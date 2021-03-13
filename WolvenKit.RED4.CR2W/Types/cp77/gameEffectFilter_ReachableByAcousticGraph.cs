using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_ReachableByAcousticGraph : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] [RED("maxPathLength")] public gameEffectInputParameter_Float MaxPathLength { get; set; }

		public gameEffectFilter_ReachableByAcousticGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
