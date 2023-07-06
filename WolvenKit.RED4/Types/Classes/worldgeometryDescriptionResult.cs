using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldgeometryDescriptionResult : IScriptable
	{
		[Ordinal(0)] 
		[RED("leftHandData")] 
		public worldgeometryHandIKDescriptionResult LeftHandData
		{
			get => GetPropertyValue<worldgeometryHandIKDescriptionResult>();
			set => SetPropertyValue<worldgeometryHandIKDescriptionResult>(value);
		}

		[Ordinal(1)] 
		[RED("rightHandData")] 
		public worldgeometryHandIKDescriptionResult RightHandData
		{
			get => GetPropertyValue<worldgeometryHandIKDescriptionResult>();
			set => SetPropertyValue<worldgeometryHandIKDescriptionResult>(value);
		}

		[Ordinal(2)] 
		[RED("collisionNormal")] 
		public Vector4 CollisionNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("topPoint")] 
		public Vector4 TopPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("topNormal")] 
		public Vector4 TopNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("behindPoint")] 
		public Vector4 BehindPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("behindNormal")] 
		public Vector4 BehindNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("upExtent")] 
		public CFloat UpExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("downExtent")] 
		public CFloat DownExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("topExtent")] 
		public CFloat TopExtent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("obstacleDepthStatus")] 
		public CEnum<worldgeometryProbingStatus> ObstacleDepthStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(13)] 
		[RED("leftExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> LeftExtentStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(14)] 
		[RED("rightExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> RightExtentStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(15)] 
		[RED("upExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> UpExtentStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(16)] 
		[RED("downExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> DownExtentStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(17)] 
		[RED("topTestStatus")] 
		public CEnum<worldgeometryProbingStatus> TopTestStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(18)] 
		[RED("behindTestStatus")] 
		public CEnum<worldgeometryProbingStatus> BehindTestStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryProbingStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryProbingStatus>>(value);
		}

		[Ordinal(19)] 
		[RED("queryStatus")] 
		public CEnum<worldgeometryDescriptionQueryStatus> QueryStatus
		{
			get => GetPropertyValue<CEnum<worldgeometryDescriptionQueryStatus>>();
			set => SetPropertyValue<CEnum<worldgeometryDescriptionQueryStatus>>(value);
		}

		[Ordinal(20)] 
		[RED("climbedEntity")] 
		public CWeakHandle<entEntity> ClimbedEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public worldgeometryDescriptionResult()
		{
			LeftHandData = new worldgeometryHandIKDescriptionResult { GrabPointStart = new Vector4(), GrabPointEnd = new Vector4() };
			RightHandData = new worldgeometryHandIKDescriptionResult { GrabPointStart = new Vector4(), GrabPointEnd = new Vector4() };
			CollisionNormal = new Vector4();
			DistanceVector = new Vector4();
			TopPoint = new Vector4();
			TopNormal = new Vector4();
			BehindPoint = new Vector4();
			BehindNormal = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
