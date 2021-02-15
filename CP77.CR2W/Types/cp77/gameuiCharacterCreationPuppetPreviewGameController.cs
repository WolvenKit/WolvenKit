using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCreationPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(7)] [RED("maleSceneName")] public CName MaleSceneName { get; set; }
		[Ordinal(8)] [RED("femaleSceneName")] public CName FemaleSceneName { get; set; }
		[Ordinal(9)] [RED("maleCamera01Ref")] public NodeRef MaleCamera01Ref { get; set; }
		[Ordinal(10)] [RED("femaleCamera01Ref")] public NodeRef FemaleCamera01Ref { get; set; }
		[Ordinal(11)] [RED("root")] public inkCompoundWidgetReference Root { get; set; }
		[Ordinal(12)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(13)] [RED("animLib")] public inkWidgetLibraryReference AnimLib { get; set; }
		[Ordinal(14)] [RED("animName")] public CName AnimName { get; set; }

		public gameuiCharacterCreationPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
