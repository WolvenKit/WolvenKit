using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePatrolSplineProgress : ISerializable
	{
		[Ordinal(0)] [RED("currentControlPoints")] public CArray<gamePatrolSplineControlPoint> CurrentControlPoints { get; set; }
		[Ordinal(1)] [RED("entrySplineParam")] public CFloat EntrySplineParam { get; set; }
		[Ordinal(2)] [RED("controlPointIndex")] public CUInt32 ControlPointIndex { get; set; }

		public gamePatrolSplineProgress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
