using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionEvent : redEvent
	{
		[Ordinal(0)]  [RED("actionID")] public CName ActionID { get; set; }
		[Ordinal(1)]  [RED("enabled")] public CBool Enabled { get; set; }

		public ToggleCustomActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
