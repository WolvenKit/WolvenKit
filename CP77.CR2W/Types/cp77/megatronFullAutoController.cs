using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class megatronFullAutoController : AmmoLogicController
	{
		[Ordinal(0)]  [RED("ammoBar")] public wCHandle<inkImageWidget> AmmoBar { get; set; }
		[Ordinal(1)]  [RED("ammoCountText")] public wCHandle<inkTextWidget> AmmoCountText { get; set; }

		public megatronFullAutoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
