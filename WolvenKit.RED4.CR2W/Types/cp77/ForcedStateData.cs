using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForcedStateData : CVariable
	{
		[Ordinal(0)] [RED("state")] public CEnum<ECLSForcedState> State { get; set; }
		[Ordinal(1)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(2)] [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(3)] [RED("savable")] public CBool Savable { get; set; }

		public ForcedStateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
