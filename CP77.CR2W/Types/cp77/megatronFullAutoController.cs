using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class megatronFullAutoController : AmmoLogicController
	{
		[Ordinal(3)] [RED("ammoCountText")] public wCHandle<inkTextWidget> AmmoCountText { get; set; }
		[Ordinal(4)] [RED("ammoBar")] public wCHandle<inkImageWidget> AmmoBar { get; set; }

		public megatronFullAutoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
