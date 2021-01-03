using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UndressPlayer : redEvent
	{
		[Ordinal(0)]  [RED("isCensored")] public CBool IsCensored { get; set; }

		public UndressPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
