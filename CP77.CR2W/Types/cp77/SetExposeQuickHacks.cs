using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetExposeQuickHacks : ActionBool
	{
		[Ordinal(0)]  [RED("isRemote")] public CBool IsRemote { get; set; }

		public SetExposeQuickHacks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
