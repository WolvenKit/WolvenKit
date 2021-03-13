using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphImageThumbnail : inkButtonAnimatedController
	{
		[Ordinal(22)] [RED("selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(23)] [RED("equipped")] public inkWidgetReference Equipped { get; set; }
		[Ordinal(24)] [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(25)] [RED("index")] public CInt32 Index { get; set; }

		public characterCreationBodyMorphImageThumbnail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
