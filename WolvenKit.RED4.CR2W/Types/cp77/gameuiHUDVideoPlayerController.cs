using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoPlayerController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("playOnHud")] public CBool PlayOnHud { get; set; }

		public gameuiHUDVideoPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
