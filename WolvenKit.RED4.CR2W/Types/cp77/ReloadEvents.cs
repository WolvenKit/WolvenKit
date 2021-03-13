using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadEvents : WeaponEventsTransition
	{
		[Ordinal(0)] [RED("randomSync")] public CHandle<AnimFeature_SelectRandomAnimSync> RandomSync { get; set; }
		[Ordinal(1)] [RED("sprintingLastUpdate")] public CBool SprintingLastUpdate { get; set; }
		[Ordinal(2)] [RED("uninteruptibleSet")] public CBool UninteruptibleSet { get; set; }

		public ReloadEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
