using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RetractableAd : BaseAnimatedDevice
	{
		[Ordinal(98)] [RED("offMeshConnection")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnection { get; set; }
		[Ordinal(99)] [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(100)] [RED("advUiComponent")] public CHandle<entIComponent> AdvUiComponent { get; set; }
		[Ordinal(101)] [RED("isPartOfTheTrap")] public CBool IsPartOfTheTrap { get; set; }

		public RetractableAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
