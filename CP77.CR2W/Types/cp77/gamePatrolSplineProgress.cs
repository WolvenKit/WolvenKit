using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
