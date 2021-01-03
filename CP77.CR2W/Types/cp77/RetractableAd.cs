using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RetractableAd : BaseAnimatedDevice
	{
		[Ordinal(0)]  [RED("advUiComponent")] public CHandle<entIComponent> AdvUiComponent { get; set; }
		[Ordinal(1)]  [RED("areaComponent")] public CHandle<gameStaticTriggerAreaComponent> AreaComponent { get; set; }
		[Ordinal(2)]  [RED("isPartOfTheTrap")] public CBool IsPartOfTheTrap { get; set; }
		[Ordinal(3)]  [RED("offMeshConnection")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnection { get; set; }

		public RetractableAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
