using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActionInteractivityInfo : CVariable
	{
		[Ordinal(0)]  [RED("isDirect")] public CBool IsDirect { get; set; }
		[Ordinal(1)]  [RED("isExternal")] public CBool IsExternal { get; set; }
		[Ordinal(2)]  [RED("isRemote")] public CBool IsRemote { get; set; }

		public ActionInteractivityInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
