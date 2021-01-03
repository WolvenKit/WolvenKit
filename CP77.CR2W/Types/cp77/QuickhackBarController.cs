using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickhackBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("empty")] public inkWidgetReference Empty { get; set; }
		[Ordinal(1)]  [RED("emptyMask")] public inkWidgetReference EmptyMask { get; set; }
		[Ordinal(2)]  [RED("full")] public inkWidgetReference Full { get; set; }

		public QuickhackBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
