using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimTargetsEvent : redEvent
	{
		[Ordinal(0)] [RED("targets")] public CArray<StimTargetData> Targets { get; set; }
		[Ordinal(1)] [RED("restore")] public CBool Restore { get; set; }

		public StimTargetsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
