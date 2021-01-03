using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeUIVisibilityEvent : redEvent
	{
		[Ordinal(0)]  [RED("visible")] public CBool Visible { get; set; }

		public gameuiPhotoModeUIVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
