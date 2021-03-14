using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_QuerySphere : gameEffectObjectProvider
	{
		[Ordinal(0)] [RED("gatherOnlyPuppets")] public CBool GatherOnlyPuppets { get; set; }
		[Ordinal(1)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }

		public gameEffectObjectProvider_QuerySphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
