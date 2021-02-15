using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataTerm : InteractiveDevice
	{
		[Ordinal(93)] [RED("linkedFastTravelPoint")] public CHandle<gameFastTravelPointData> LinkedFastTravelPoint { get; set; }
		[Ordinal(94)] [RED("exitNode")] public NodeRef ExitNode { get; set; }
		[Ordinal(95)] [RED("fastTravelComponent")] public CHandle<FastTravelComponent> FastTravelComponent { get; set; }
		[Ordinal(96)] [RED("lockColiderComponent")] public CHandle<entIPlacedComponent> LockColiderComponent { get; set; }
		[Ordinal(97)] [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(98)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(99)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public DataTerm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
