using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_OnlyNearestMelee : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] [RED("count")] public CUInt32 Count { get; set; }

		public gameEffectObjectFilter_OnlyNearestMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
