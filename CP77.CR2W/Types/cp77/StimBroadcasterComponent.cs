using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StimBroadcasterComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("activeRequests")] public CArray<CHandle<StimRequest>> ActiveRequests { get; set; }
		[Ordinal(1)]  [RED("currentID")] public CUInt32 CurrentID { get; set; }
		[Ordinal(2)]  [RED("fallbackInterval")] public CFloat FallbackInterval { get; set; }
		[Ordinal(3)]  [RED("shouldBroadcast")] public CBool ShouldBroadcast { get; set; }
		[Ordinal(4)]  [RED("targets")] public CArray<NPCstubData> Targets { get; set; }

		public StimBroadcasterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
