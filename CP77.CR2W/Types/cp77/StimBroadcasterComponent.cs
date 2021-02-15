using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimBroadcasterComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("activeRequests")] public CArray<CHandle<StimRequest>> ActiveRequests { get; set; }
		[Ordinal(6)] [RED("currentID")] public CUInt32 CurrentID { get; set; }
		[Ordinal(7)] [RED("shouldBroadcast")] public CBool ShouldBroadcast { get; set; }
		[Ordinal(8)] [RED("targets")] public CArray<NPCstubData> Targets { get; set; }
		[Ordinal(9)] [RED("fallbackInterval")] public CFloat FallbackInterval { get; set; }

		public StimBroadcasterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
