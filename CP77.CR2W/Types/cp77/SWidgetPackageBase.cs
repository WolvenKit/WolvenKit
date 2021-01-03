using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackageBase : CVariable
	{
		[Ordinal(0)]  [RED("isValid")] public CBool IsValid { get; set; }
		[Ordinal(1)]  [RED("libraryID")] public CName LibraryID { get; set; }
		[Ordinal(2)]  [RED("libraryPath")] public redResourceReferenceScriptToken LibraryPath { get; set; }
		[Ordinal(3)]  [RED("placement")] public CEnum<EWidgetPlacementType> Placement { get; set; }
		[Ordinal(4)]  [RED("widget")] public wCHandle<inkWidget> Widget { get; set; }
		[Ordinal(5)]  [RED("widgetName")] public CString WidgetName { get; set; }
		[Ordinal(6)]  [RED("widgetTweakDBID")] public TweakDBID WidgetTweakDBID { get; set; }

		public SWidgetPackageBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
