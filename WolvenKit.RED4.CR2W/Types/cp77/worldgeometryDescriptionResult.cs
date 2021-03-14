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
			get
			{
				if (_leftHandData == null)
				{
					_leftHandData = (worldgeometryHandIKDescriptionResult) CR2WTypeManager.Create("worldgeometryHandIKDescriptionResult", "leftHandData", cr2w, this);
				}
				return _leftHandData;
			}
			set
			{
				if (_leftHandData == value)
				{
					return;
				}
				_leftHandData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rightHandData")] 
		public worldgeometryHandIKDescriptionResult RightHandData
		{
			get
			{
				if (_rightHandData == null)
				{
					_rightHandData = (worldgeometryHandIKDescriptionResult) CR2WTypeManager.Create("worldgeometryHandIKDescriptionResult", "rightHandData", cr2w, this);
				}
				return _rightHandData;
			}
			set
			{
				if (_rightHandData == value)
				{
					return;
				}
				_rightHandData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("collisionNormal")] 
		public Vector4 CollisionNormal
		{
			get
			{
				if (_collisionNormal == null)
				{
					_collisionNormal = (Vector4) CR2WTypeManager.Create("Vector4", "collisionNormal", cr2w, this);
				}
				return _collisionNormal;
			}
			set
			{
				if (_collisionNormal == value)
				{
					return;
				}
				_collisionNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get
			{
				if (_distanceVector == null)
				{
					_distanceVector = (Vector4) CR2WTypeManager.Create("Vector4", "distanceVector", cr2w, this);
				}
				return _distanceVector;
			}
			set
			{
				if (_distanceVector == value)
				{
					return;
				}
				_distanceVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("topPoint")] 
		public Vector4 TopPoint
		{
			get
			{
				if (_topPoint == null)
				{
					_topPoint = (Vector4) CR2WTypeManager.Create("Vector4", "topPoint", cr2w, this);
				}
				return _topPoint;
			}
			set
			{
				if (_topPoint == value)
				{
					return;
				}
				_topPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("topNormal")] 
		public Vector4 TopNormal
		{
			get
			{
				if (_topNormal == null)
				{
					_topNormal = (Vector4) CR2WTypeManager.Create("Vector4", "topNormal", cr2w, this);
				}
				return _topNormal;
			}
			set
			{
				if (_topNormal == value)
				{
					return;
				}
				_topNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("behindPoint")] 
		public Vector4 BehindPoint
		{
			get
			{
				if (_behindPoint == null)
				{
					_behindPoint = (Vector4) CR2WTypeManager.Create("Vector4", "behindPoint", cr2w, this);
				}
				return _behindPoint;
			}
			set
			{
				if (_behindPoint == value)
				{
					return;
				}
				_behindPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("behindNormal")] 
		public Vector4 BehindNormal
		{
			get
			{
				if (_behindNormal == null)
				{
					_behindNormal = (Vector4) CR2WTypeManager.Create("Vector4", "behindNormal", cr2w, this);
				}
				return _behindNormal;
			}
			set
			{
				if (_behindNormal == value)
				{
					return;
				}
				_behindNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("obstacleDepth")] 
		public CFloat ObstacleDepth
		{
			get
			{
				if (_obstacleDepth == null)
				{
					_obstacleDepth = (CFloat) CR2WTypeManager.Create("Float", "obstacleDepth", cr2w, this);
				}
				return _obstacleDepth;
			}
			set
			{
				if (_obstacleDepth == value)
				{
					return;
				}
				_obstacleDepth = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("upExtent")] 
		public CFloat UpExtent
		{
			get
			{
				if (_upExtent == null)
				{
					_upExtent = (CFloat) CR2WTypeManager.Create("Float", "upExtent", cr2w, this);
				}
				return _upExtent;
			}
			set
			{
				if (_upExtent == value)
				{
					return;
				}
				_upExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("downExtent")] 
		public CFloat DownExtent
		{
			get
			{
				if (_downExtent == null)
				{
					_downExtent = (CFloat) CR2WTypeManager.Create("Float", "downExtent", cr2w, this);
				}
				return _downExtent;
			}
			set
			{
				if (_downExtent == value)
				{
					return;
				}
				_downExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("topExtent")] 
		public CFloat TopExtent
		{
			get
			{
				if (_topExtent == null)
				{
					_topExtent = (CFloat) CR2WTypeManager.Create("Float", "topExtent", cr2w, this);
				}
				return _topExtent;
			}
			set
			{
				if (_topExtent == value)
				{
					return;
				}
				_topExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("obstacleDepthStatus")] 
		public CEnum<worldgeometryProbingStatus> ObstacleDepthStatus
		{
			get
			{
				if (_obstacleDepthStatus == null)
				{
					_obstacleDepthStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "obstacleDepthStatus", cr2w, this);
				}
				return _obstacleDepthStatus;
			}
			set
			{
				if (_obstacleDepthStatus == value)
				{
					return;
				}
				_obstacleDepthStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("leftExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> LeftExtentStatus
		{
			get
			{
				if (_leftExtentStatus == null)
				{
					_leftExtentStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "leftExtentStatus", cr2w, this);
				}
				return _leftExtentStatus;
			}
			set
			{
				if (_leftExtentStatus == value)
				{
					return;
				}
				_leftExtentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rightExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> RightExtentStatus
		{
			get
			{
				if (_rightExtentStatus == null)
				{
					_rightExtentStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "rightExtentStatus", cr2w, this);
				}
				return _rightExtentStatus;
			}
			set
			{
				if (_rightExtentStatus == value)
				{
					return;
				}
				_rightExtentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("upExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> UpExtentStatus
		{
			get
			{
				if (_upExtentStatus == null)
				{
					_upExtentStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "upExtentStatus", cr2w, this);
				}
				return _upExtentStatus;
			}
			set
			{
				if (_upExtentStatus == value)
				{
					return;
				}
				_upExtentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("downExtentStatus")] 
		public CEnum<worldgeometryProbingStatus> DownExtentStatus
		{
			get
			{
				if (_downExtentStatus == null)
				{
					_downExtentStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "downExtentStatus", cr2w, this);
				}
				return _downExtentStatus;
			}
			set
			{
				if (_downExtentStatus == value)
				{
					return;
				}
				_downExtentStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("topTestStatus")] 
		public CEnum<worldgeometryProbingStatus> TopTestStatus
		{
			get
			{
				if (_topTestStatus == null)
				{
					_topTestStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "topTestStatus", cr2w, this);
				}
				return _topTestStatus;
			}
			set
			{
				if (_topTestStatus == value)
				{
					return;
				}
				_topTestStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("behindTestStatus")] 
		public CEnum<worldgeometryProbingStatus> BehindTestStatus
		{
			get
			{
				if (_behindTestStatus == null)
				{
					_behindTestStatus = (CEnum<worldgeometryProbingStatus>) CR2WTypeManager.Create("worldgeometryProbingStatus", "behindTestStatus", cr2w, this);
				}
				return _behindTestStatus;
			}
			set
			{
				if (_behindTestStatus == value)
				{
					return;
				}
				_behindTestStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("queryStatus")] 
		public CEnum<worldgeometryDescriptionQueryStatus> QueryStatus
		{
			get
			{
				if (_queryStatus == null)
				{
					_queryStatus = (CEnum<worldgeometryDescriptionQueryStatus>) CR2WTypeManager.Create("worldgeometryDescriptionQueryStatus", "queryStatus", cr2w, this);
				}
				return _queryStatus;
			}
			set
			{
				if (_queryStatus == value)
				{
					return;
				}
				_queryStatus = value;
				PropertySet(this);
			}
		}

		public worldgeometryDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
