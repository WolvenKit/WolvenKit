using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeCursorStateChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("cursorEnabled")] public CBool CursorEnabled { get; set; }

		public inkPhotoModeCursorStateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
