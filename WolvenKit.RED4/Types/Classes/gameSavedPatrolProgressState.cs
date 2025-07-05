using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSavedPatrolProgressState : ISerializable
	{
		[Ordinal(0)] 
		[RED("entrySplineParam")] 
		public CFloat EntrySplineParam
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("entrySectionIndex")] 
		public CUInt32 EntrySectionIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("controlPointIndex")] 
		public CUInt32 ControlPointIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("splineEntryPosition")] 
		public Vector3 SplineEntryPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("splineEntryTangent")] 
		public Vector3 SplineEntryTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("isSplineReversed")] 
		public CBool IsSplineReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("currentDestinationPosition")] 
		public Vector3 CurrentDestinationPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("currentDestinationTangent")] 
		public Vector3 CurrentDestinationTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameSavedPatrolProgressState()
		{
			SplineEntryPosition = new Vector3();
			SplineEntryTangent = new Vector3();
			CurrentDestinationPosition = new Vector3();
			CurrentDestinationTangent = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
