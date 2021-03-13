using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronFullAutoController : AmmoLogicController
	{
		[Ordinal(3)] [RED("ammoCountText")] public wCHandle<inkTextWidget> AmmoCountText { get; set; }
		[Ordinal(4)] [RED("ammoBar")] public wCHandle<inkImageWidget> AmmoBar { get; set; }

		public megatronFullAutoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
