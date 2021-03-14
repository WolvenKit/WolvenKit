using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinition : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("rootLibrary")] public rRef<inkWidgetLibraryResource> RootLibrary { get; set; }
		[Ordinal(2)] [RED("activeByDefault")] public CBool ActiveByDefault { get; set; }
		[Ordinal(3)] [RED("isPermanent")] public CBool IsPermanent { get; set; }
		[Ordinal(4)] [RED("useGlobalStyleTheme")] public CBool UseGlobalStyleTheme { get; set; }
		[Ordinal(5)] [RED("isAffectedByFadeout")] public CBool IsAffectedByFadeout { get; set; }
		[Ordinal(6)] [RED("useGameInput")] public CBool UseGameInput { get; set; }
		[Ordinal(7)] [RED("inputContext")] public CName InputContext { get; set; }

		public inkLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
