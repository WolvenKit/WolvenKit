using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryDescriptionResult : IScriptable
	{
		private worldgeometryHandIKDescriptionResult _leftHandData;
		private worldgeometryHandIKDescriptionResult _rightHandData;
		private Vector4 _collisionNormal;
		private Vector4 _distanceVector;
		private Vector4 _topPoint;
		private Vector4 _topNormal;
		private Vector4 _behindPoint;
		private Vector4 _behindNormal;
		private CFloat _obstacleDepth;
		private CFloat _upExtent;
		private CFloat _downExtent;
		private CFloat _topExtent;
		private CEnum<worldgeometryProbingStatus> _obstacleDepthStatus;
		private CEnum<worldgeometryProbingStatus> _leftExtentStatus;
		private CEnum<worldgeometryProbingStatus> _rightExtentStatus;
		private CEnum<worldgeometryProbingStatus> _upExtentStatus;
		private CEnum<worldgeometryProbingStatus> _downExtentStatus;
		private CEnum<worldgeometryProbingStatus> _topTestStatus;
		private CEnum<worldgeometryProbingStatus> _behindTestStatus;
		private CEnum<worldgeometryDescriptionQueryStatus> _queryStatus;

		[Ordinal(0)] 
		[RED("leftHandData")] 
		public worldgeometryHandIKDescriptionResult LeftHandData
		{
			get => GetProperty(ref _leftHandData);
			set => SetProperty(ref _leftHandData, value);
		}

		[Ordinal(1)] 
		[RED("rightHandData")] 
		public worldgeometryHandIKDescriptionResult RightHandData
		{
			get => GetProperty(ref _rightHandData);
			set => SetProperty(ref _rightHandData, value);
		}

		[Ordinal(2)] 
		[RED("collisionNormal")] 
		public Vector4 CollisionNormal
		{
			get => GetProperty(ref _collisionNormal);
			set => SetProperty(ref _collisionNormal, value);
		}

		[Ordinal(3)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get => GetProperty(ref _distanceVector);
			set => SetProperty(ref _distanceVector, value);
		}

		[Ordinal(4)] 
		[RED("topPoint")] 
		public Vector4 TopPoint
		{
			get => GetProperty(ref _topPoint);
			set => SetProperty(ref _topPoint, value);
		}

		[Ordinal(5)] 
		[RED("topNormal")] 
		public Vector4 TopNormal
		{
			get => GetProperty(ref _topNormal);
			set => SetProperty(ref _topNormal, value);
		}

		[Ordinal(6)] 
		[RED("behindPoint")] 
		public Vector4 BehindPoint
		{
			get => GetProperty(ref _behindPoint);
			set => SetProperty(ref _behindPoint, value);
		}

		[Ordinal(7)] 
		[RED("behindNormal")] 
		public Vector4 BehindNormal
		{
			get => GetProperty(ref _behindNormal);
			set => SetProperty(ref _behindNormal, value);
		}

		[Ordinal(8)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get => GetProperty(ref _obstacleDepth);
			set => SetProperty(ref _obstacleDepth, value);
		}

		[Ordinal(9)] 
		[RED("upExtent")] 
		public CFloat UpExtent
		{
			get => GetProperty(ref _upExtent);
			set => SetProperty(ref _upExtent, value);
		}

		[Ordinal(10)] 
		[RED("downExtent")] 
		public CFloat DownExtent
		{
			get => GetProperty(ref _downExtent);
			set => SetProperty(ref _downExtent, value);
		}

		[Ordinal(11)] 
		[RED("topExtent")] 
		public CFloat TopExtent
		{
			get => GetProperty(ref _topExtent);
			set => SetProperty(ref _topExtent, value);
		}

		[Ordinal(12)] 
		[RED("obstacleDepthStatus")] 
		public CEnum<worldgeometryProbingStatus> ObstacleDepthStatus
		{
			get => GetProperty(ref _obstacleDepthStatus);
			set => SetProperty(ref _obstacleDepthStatus, value);
		}

		[Ordinal(13)] 
		[RED("leftExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> LeftExtentStatus
		{
			get => GetProperty(ref _leftExtentStatus);
			set => SetProperty(ref _leftExtentStatus, value);
		}

		[Ordinal(14)] 
		[RED("rightExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> RightExtentStatus
		{
			get => GetProperty(ref _rightExtentStatus);
			set => SetProperty(ref _rightExtentStatus, value);
		}

		[Ordinal(15)] 
		[RED("upExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> UpExtentStatus
		{
			get => GetProperty(ref _upExtentStatus);
			set => SetProperty(ref _upExtentStatus, value);
		}

		[Ordinal(16)] 
		[RED("downExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> DownExtentStatus
		{
			get => GetProperty(ref _downExtentStatus);
			set => SetProperty(ref _downExtentStatus, value);
		}

		[Ordinal(17)] 
		[RED("topTestStatus")] 
		public CEnum<worldgeometryProbingStatus> TopTestStatus
		{
			get => GetProperty(ref _topTestStatus);
			set => SetProperty(ref _topTestStatus, value);
		}

		[Ordinal(18)] 
		[RED("behindTestStatus")] 
		public CEnum<worldgeometryProbingStatus> BehindTestStatus
		{
			get => GetProperty(ref _behindTestStatus);
			set => SetProperty(ref _behindTestStatus, value);
		}

		[Ordinal(19)] 
		[RED("queryStatus")] 
		public CEnum<worldgeometryDescriptionQueryStatus> QueryStatus
		{
			get => GetProperty(ref _queryStatus);
			set => SetProperty(ref _queryStatus, value);
		}

		public worldgeometryDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
