using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("aggregationType")] public CEnum<gameAggregationType> AggregationType { get; set; }
		[Ordinal(1)] [RED("nestedPrereqs")] public CArray<CHandle<gameIPrereq>> NestedPrereqs { get; set; }

		public gameMultiPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
