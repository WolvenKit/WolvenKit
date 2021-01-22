using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphImageThumbnail : inkButtonAnimatedController
	{
		[Ordinal(0)]  [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(1)]  [RED("equipped")] public inkWidgetReference Equipped { get; set; }
		[Ordinal(2)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(3)]  [RED("selector")] public inkWidgetReference Selector { get; set; }

		public characterCreationBodyMorphImageThumbnail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
