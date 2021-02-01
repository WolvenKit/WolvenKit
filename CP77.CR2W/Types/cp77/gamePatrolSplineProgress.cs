using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePatrolSplineProgress : ISerializable
	{
		[Ordinal(0)]  [RED("controlPointIndex")] public CUInt32 ControlPointIndex { get; set; }
		[Ordinal(1)]  [RED("currentControlPoints")] public CArray<gamePatrolSplineControlPoint> CurrentControlPoints { get; set; }
		[Ordinal(2)]  [RED("entrySplineParam")] public CFloat EntrySplineParam { get; set; }

		public gamePatrolSplineProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
