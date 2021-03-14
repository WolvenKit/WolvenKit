using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPath : ISerializable
	{
		private NodeRef _splineNodeRef;
		private CArray<navLocomotionPathSegmentInfo> _segments;
		private CArray<navLocomotionPathSegmentInfo> _backwardSegments;
		private CArray<navLocomotionPathPointInfo> _points;
		private CArray<navLocomotionPathPointUserDataEntry> _userData;

		[Ordinal(0)] 
		[RED("splineNodeRef")] 
		public NodeRef SplineNodeRef
		{
			get
			{
				if (_splineNodeRef == null)
				{
					_splineNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineNodeRef", cr2w, this);
				}
				return _splineNodeRef;
			}
			set
			{
				if (_splineNodeRef == value)
				{
					return;
				}
				_splineNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("segments")] 
		public CArray<navLocomotionPathSegmentInfo> Segments
		{
			get
			{
				if (_segments == null)
				{
					_segments = (CArray<navLocomotionPathSegmentInfo>) CR2WTypeManager.Create("array:navLocomotionPathSegmentInfo", "segments", cr2w, this);
				}
				return _segments;
			}
			set
			{
				if (_segments == value)
				{
					return;
				}
				_segments = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("backwardSegments")] 
		public CArray<navLocomotionPathSegmentInfo> BackwardSegments
		{
			get
			{
				if (_backwardSegments == null)
				{
					_backwardSegments = (CArray<navLocomotionPathSegmentInfo>) CR2WTypeManager.Create("array:navLocomotionPathSegmentInfo", "backwardSegments", cr2w, this);
				}
				return _backwardSegments;
			}
			set
			{
				if (_backwardSegments == value)
				{
					return;
				}
				_backwardSegments = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("points")] 
		public CArray<navLocomotionPathPointInfo> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArray<navLocomotionPathPointInfo>) CR2WTypeManager.Create("array:navLocomotionPathPointInfo", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CArray<navLocomotionPathPointUserDataEntry> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CArray<navLocomotionPathPointUserDataEntry>) CR2WTypeManager.Create("array:navLocomotionPathPointUserDataEntry", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		public navLocomotionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
