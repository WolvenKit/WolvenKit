using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionSlideParams : CVariable
	{
		private CFloat _distance;
		private CFloat _directionAngle;
		private CFloat _duration;
		private CFloat _offset;
		private CBool _slideToTarget;
		private CBool _debugDrawSlideLines;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(1)] 
		[RED("directionAngle")] 
		public CFloat DirectionAngle
		{
			get => GetProperty(ref _directionAngle);
			set => SetProperty(ref _directionAngle, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(4)] 
		[RED("slideToTarget")] 
		public CBool SlideToTarget
		{
			get => GetProperty(ref _slideToTarget);
			set => SetProperty(ref _slideToTarget, value);
		}

		[Ordinal(5)] 
		[RED("debugDrawSlideLines")] 
		public CBool DebugDrawSlideLines
		{
			get => GetProperty(ref _debugDrawSlideLines);
			set => SetProperty(ref _debugDrawSlideLines, value);
		}

		public AIActionSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
