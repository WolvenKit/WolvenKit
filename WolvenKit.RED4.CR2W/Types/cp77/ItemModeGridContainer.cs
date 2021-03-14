using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridContainer : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("scrollControllerWidget")] public inkCompoundWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(2)] [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }
		[Ordinal(3)] [RED("itemsGridWidget")] public inkWidgetReference ItemsGridWidget { get; set; }
		[Ordinal(4)] [RED("filterGridWidget")] public inkCompoundWidgetReference FilterGridWidget { get; set; }
		[Ordinal(5)] [RED("F_eyesTexture")] public inkWidgetReference F_eyesTexture { get; set; }
		[Ordinal(6)] [RED("F_systemReplacementTexture")] public inkWidgetReference F_systemReplacementTexture { get; set; }
		[Ordinal(7)] [RED("F_handsTexture")] public inkWidgetReference F_handsTexture { get; set; }
		[Ordinal(8)] [RED("M_eyesTexture")] public inkWidgetReference M_eyesTexture { get; set; }
		[Ordinal(9)] [RED("M_systemReplacementTexture")] public inkWidgetReference M_systemReplacementTexture { get; set; }
		[Ordinal(10)] [RED("M_handsTexture")] public inkWidgetReference M_handsTexture { get; set; }
		[Ordinal(11)] [RED("outroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }

		public ItemModeGridContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
