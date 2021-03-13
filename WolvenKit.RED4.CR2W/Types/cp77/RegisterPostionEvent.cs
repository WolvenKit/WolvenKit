using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPostionEvent : BlackBoardRequestEvent
	{
		[Ordinal(3)] [RED("start")] public CBool Start { get; set; }

		public RegisterPostionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
