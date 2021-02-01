using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnVehicleMoveOnSpline_Overrides : questIVehicleMoveOnSpline_Overrides
	{
		[Ordinal(0)]  [RED("entryMarker")] public scnMarker EntryMarker { get; set; }
		[Ordinal(1)]  [RED("entrySpeed")] public CFloat EntrySpeed { get; set; }
		[Ordinal(2)]  [RED("entryTransform")] public Transform EntryTransform { get; set; }
		[Ordinal(3)]  [RED("exitMarker")] public scnMarker ExitMarker { get; set; }
		[Ordinal(4)]  [RED("exitSpeed")] public CFloat ExitSpeed { get; set; }
		[Ordinal(5)]  [RED("exitTransform")] public Transform ExitTransform { get; set; }
		[Ordinal(6)]  [RED("useEntry")] public CBool UseEntry { get; set; }
		[Ordinal(7)]  [RED("useExit")] public CBool UseExit { get; set; }

		public scnVehicleMoveOnSpline_Overrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
