using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DataTerm : InteractiveDevice
	{
		[Ordinal(0)]  [RED("exitNode")] public NodeRef ExitNode { get; set; }
		[Ordinal(1)]  [RED("fastTravelComponent")] public CHandle<FastTravelComponent> FastTravelComponent { get; set; }
		[Ordinal(2)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(3)]  [RED("linkedFastTravelPoint")] public CHandle<gameFastTravelPointData> LinkedFastTravelPoint { get; set; }
		[Ordinal(4)]  [RED("lockColiderComponent")] public CHandle<entIPlacedComponent> LockColiderComponent { get; set; }
		[Ordinal(5)]  [RED("mappinID")] public gameNewMappinID MappinID { get; set; }
		[Ordinal(6)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public DataTerm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
