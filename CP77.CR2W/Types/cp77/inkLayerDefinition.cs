using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinition : CVariable
	{
		[Ordinal(0)]  [RED("activeByDefault")] public CBool ActiveByDefault { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(2)]  [RED("inputContext")] public CName InputContext { get; set; }
		[Ordinal(3)]  [RED("isAffectedByFadeout")] public CBool IsAffectedByFadeout { get; set; }
		[Ordinal(4)]  [RED("isPermanent")] public CBool IsPermanent { get; set; }
		[Ordinal(5)]  [RED("rootLibrary")] public rRef<inkWidgetLibraryResource> RootLibrary { get; set; }
		[Ordinal(6)]  [RED("useGameInput")] public CBool UseGameInput { get; set; }
		[Ordinal(7)]  [RED("useGlobalStyleTheme")] public CBool UseGlobalStyleTheme { get; set; }

		public inkLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
