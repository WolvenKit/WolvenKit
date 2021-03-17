using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_RotateOnAxis : gameTransformAnimationTrackItemImpl
	{
		private CEnum<gameTransformAnimation_RotateOnAxisAxis> _axis;
		private CFloat _numberOfFullRotations;
		private CFloat _startAngle;
		private CBool _reverseDirection;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("axis")] 
		public CEnum<gameTransformAnimation_RotateOnAxisAxis> Axis
		{
			get => GetProperty(ref _axis);
			set => SetProperty(ref _axis, value);
		}

		[Ordinal(1)] 
		[RED("numberOfFullRotations")] 
		public CFloat NumberOfFullRotations
		{
			get => GetProperty(ref _numberOfFullRotations);
			set => SetProperty(ref _numberOfFullRotations, value);
		}

		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get => GetProperty(ref _startAngle);
			set => SetProperty(ref _startAngle, value);
		}

		[Ordinal(3)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetProperty(ref _reverseDirection);
			set => SetProperty(ref _reverseDirection, value);
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		public gameTransformAnimation_RotateOnAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
