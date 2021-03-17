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
			get => GetProperty(ref _splineNodeRef);
			set => SetProperty(ref _splineNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("segments")] 
		public CArray<navLocomotionPathSegmentInfo> Segments
		{
			get => GetProperty(ref _segments);
			set => SetProperty(ref _segments, value);
		}

		[Ordinal(2)] 
		[RED("backwardSegments")] 
		public CArray<navLocomotionPathSegmentInfo> BackwardSegments
		{
			get => GetProperty(ref _backwardSegments);
			set => SetProperty(ref _backwardSegments, value);
		}

		[Ordinal(3)] 
		[RED("points")] 
		public CArray<navLocomotionPathPointInfo> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}

		[Ordinal(4)] 
		[RED("userData")] 
		public CArray<navLocomotionPathPointUserDataEntry> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		public navLocomotionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
