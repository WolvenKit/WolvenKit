using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePatrolSplineProgress : IScriptable
	{
		[Ordinal(0)] 
		[RED("currentControlPoints")] 
		public CArray<gamePatrolSplineControlPoint> CurrentControlPoints
		{
			get => GetPropertyValue<CArray<gamePatrolSplineControlPoint>>();
			set => SetPropertyValue<CArray<gamePatrolSplineControlPoint>>(value);
		}

		[Ordinal(1)] 
		[RED("entrySplineParam")] 
		public CFloat EntrySplineParam
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("controlPointIndex")] 
		public CUInt32 ControlPointIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gamePatrolSplineProgress()
		{
			CurrentControlPoints = new();
			EntrySplineParam = -1.000000F;
			ControlPointIndex = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
