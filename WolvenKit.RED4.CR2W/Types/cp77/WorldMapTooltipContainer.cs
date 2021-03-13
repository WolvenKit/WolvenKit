using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipContainer : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("defaultTooltip")] public inkWidgetReference DefaultTooltip { get; set; }
		[Ordinal(2)] [RED("policeTooltip")] public inkWidgetReference PoliceTooltip { get; set; }
		[Ordinal(3)] [RED("districtTooltip")] public inkWidgetReference DistrictTooltip { get; set; }
		[Ordinal(4)] [RED("defaultTooltipController")] public wCHandle<WorldMapTooltipBaseController> DefaultTooltipController { get; set; }
		[Ordinal(5)] [RED("policeTooltipController")] public wCHandle<WorldMapTooltipBaseController> PoliceTooltipController { get; set; }
		[Ordinal(6)] [RED("districtTooltipController")] public wCHandle<WorldMapTooltipBaseController> DistrictTooltipController { get; set; }
		[Ordinal(7)] [RED("tooltips", 3)] public CArrayFixedSize<wCHandle<WorldMapTooltipBaseController>> Tooltips { get; set; }
		[Ordinal(8)] [RED("currentVisibleIndex")] public CInt32 CurrentVisibleIndex { get; set; }

		public WorldMapTooltipContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
