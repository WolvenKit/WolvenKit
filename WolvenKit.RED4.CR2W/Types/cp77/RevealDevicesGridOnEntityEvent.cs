using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDevicesGridOnEntityEvent : redEvent
	{
		[Ordinal(0)] [RED("shouldDraw")] public CBool ShouldDraw { get; set; }

		public RevealDevicesGridOnEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
