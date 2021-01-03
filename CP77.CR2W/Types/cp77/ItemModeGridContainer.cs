using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridContainer : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("F_eyesTexture")] public inkWidgetReference F_eyesTexture { get; set; }
		[Ordinal(1)]  [RED("F_handsTexture")] public inkWidgetReference F_handsTexture { get; set; }
		[Ordinal(2)]  [RED("F_systemReplacementTexture")] public inkWidgetReference F_systemReplacementTexture { get; set; }
		[Ordinal(3)]  [RED("M_eyesTexture")] public inkWidgetReference M_eyesTexture { get; set; }
		[Ordinal(4)]  [RED("M_handsTexture")] public inkWidgetReference M_handsTexture { get; set; }
		[Ordinal(5)]  [RED("M_systemReplacementTexture")] public inkWidgetReference M_systemReplacementTexture { get; set; }
		[Ordinal(6)]  [RED("filterGridWidget")] public inkCompoundWidgetReference FilterGridWidget { get; set; }
		[Ordinal(7)]  [RED("itemsGridWidget")] public inkWidgetReference ItemsGridWidget { get; set; }
		[Ordinal(8)]  [RED("outroAnimation")] public CHandle<inkanimProxy> OutroAnimation { get; set; }
		[Ordinal(9)]  [RED("scrollControllerWidget")] public inkCompoundWidgetReference ScrollControllerWidget { get; set; }
		[Ordinal(10)]  [RED("sliderWidget")] public inkWidgetReference SliderWidget { get; set; }

		public ItemModeGridContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
