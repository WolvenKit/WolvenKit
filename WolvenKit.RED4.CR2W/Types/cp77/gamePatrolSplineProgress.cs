using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePatrolSplineProgress : ISerializable
	{
		private CArray<gamePatrolSplineControlPoint> _currentControlPoints;
		private CFloat _entrySplineParam;
		private CUInt32 _controlPointIndex;

		[Ordinal(0)] 
		[RED("currentControlPoints")] 
		public CArray<gamePatrolSplineControlPoint> CurrentControlPoints
		{
			get => GetProperty(ref _currentControlPoints);
			set => SetProperty(ref _currentControlPoints, value);
		}

		[Ordinal(1)] 
		[RED("entrySplineParam")] 
		public CFloat EntrySplineParam
		{
			get => GetProperty(ref _entrySplineParam);
			set => SetProperty(ref _entrySplineParam, value);
		}

		[Ordinal(2)] 
		[RED("controlPointIndex")] 
		public CUInt32 ControlPointIndex
		{
			get => GetProperty(ref _controlPointIndex);
			set => SetProperty(ref _controlPointIndex, value);
		}

		public gamePatrolSplineProgress(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
