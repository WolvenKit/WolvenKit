using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealQuickhackMenu : HUDManagerRequest
	{
		[Ordinal(0)]  [RED("shouldOpenWheel")] public CBool ShouldOpenWheel { get; set; }

		public RevealQuickhackMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
