using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipsManager : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("GenericTooltipsNames")] public CArray<CName> GenericTooltipsNames { get; set; }
		[Ordinal(1)]  [RED("HudTooltipStylePath")] public redResourceReferenceScriptToken HudTooltipStylePath { get; set; }
		[Ordinal(2)]  [RED("IndexedTooltips")] public CArray<wCHandle<AGenericTooltipController>> IndexedTooltips { get; set; }
		[Ordinal(3)]  [RED("MenuTooltipStylePath")] public redResourceReferenceScriptToken MenuTooltipStylePath { get; set; }
		[Ordinal(4)]  [RED("NamedTooltips")] public CArray<CHandle<NamedTooltipController>> NamedTooltips { get; set; }
		[Ordinal(5)]  [RED("TooltipLibrariesReferences")] public CArray<TooltipWidgetReference> TooltipLibrariesReferences { get; set; }
		[Ordinal(6)]  [RED("TooltipLibrariesStyledReferences")] public CArray<TooltipWidgetStyledReference> TooltipLibrariesStyledReferences { get; set; }
		[Ordinal(7)]  [RED("TooltipRequesters")] public CArray<inkWidgetReference> TooltipRequesters { get; set; }
		[Ordinal(8)]  [RED("TooltipStylePath")] public redResourceReferenceScriptToken TooltipStylePath { get; set; }
		[Ordinal(9)]  [RED("TooltipsLibrary")] public redResourceReferenceScriptToken TooltipsLibrary { get; set; }
		[Ordinal(10)]  [RED("flipX")] public CBool FlipX { get; set; }
		[Ordinal(11)]  [RED("flipY")] public CBool FlipY { get; set; }
		[Ordinal(12)]  [RED("introAnim")] public CHandle<inkanimProxy> IntroAnim { get; set; }
		[Ordinal(13)]  [RED("rootMargin")] public inkMargin RootMargin { get; set; }
		[Ordinal(14)]  [RED("screenMargin")] public inkMargin ScreenMargin { get; set; }
		[Ordinal(15)]  [RED("tooltipsContainer")] public inkWidgetReference TooltipsContainer { get; set; }

		public gameuiTooltipsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
