using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActionNotifier : IScriptable
	{
		[Ordinal(0)]  [RED("external")] public CBool External { get; set; }
		[Ordinal(1)]  [RED("failed")] public CBool Failed { get; set; }
		[Ordinal(2)]  [RED("internal")] public CBool Internal { get; set; }

		public ActionNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
