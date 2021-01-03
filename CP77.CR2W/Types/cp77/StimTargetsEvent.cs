using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StimTargetsEvent : redEvent
	{
		[Ordinal(0)]  [RED("restore")] public CBool Restore { get; set; }
		[Ordinal(1)]  [RED("targets")] public CArray<StimTargetData> Targets { get; set; }

		public StimTargetsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
