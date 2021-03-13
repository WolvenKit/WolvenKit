using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIsQuickhackPanelOpenedPrereq : CVariable
	{
		[Ordinal(0)] [RED("inverted")] public CBool Inverted { get; set; }

		public gameIsQuickhackPanelOpenedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
