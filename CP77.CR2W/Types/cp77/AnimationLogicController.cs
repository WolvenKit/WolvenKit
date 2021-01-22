using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimationLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("imageView")] public inkImageWidgetReference ImageView { get; set; }

		public AnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
