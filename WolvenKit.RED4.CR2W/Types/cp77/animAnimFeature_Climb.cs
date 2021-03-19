using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Climb : animAnimFeature
	{
		private Vector4 _verticalPosition;
		private Vector4 _horizontalPosition;
		private CFloat _toVerticalTime;
		private CFloat _verticalToHorizontalTime;
		private Vector4 _frontEdgePosition;
		private Vector4 _frontEdgeNormal;
		private CFloat _yawAngle;
		private CFloat _stateLength;
		private CInt32 _climbType;
		private CInt32 _state;

		[Ordinal(0)] 
		[RED("verticalPosition")] 
		public Vector4 VerticalPosition
		{
			get => GetProperty(ref _verticalPosition);
			set => SetProperty(ref _verticalPosition, value);
		}

		[Ordinal(1)] 
		[RED("horizontalPosition")] 
		public Vector4 HorizontalPosition
		{
			get => GetProperty(ref _horizontalPosition);
			set => SetProperty(ref _horizontalPosition, value);
		}

		[Ordinal(2)] 
		[RED("toVerticalTime")] 
		public CFloat ToVerticalTime
		{
			get => GetProperty(ref _toVerticalTime);
			set => SetProperty(ref _toVerticalTime, value);
		}

		[Ordinal(3)] 
		[RED("verticalToHorizontalTime")] 
		public CFloat VerticalToHorizontalTime
		{
			get => GetProperty(ref _verticalToHorizontalTime);
			set => SetProperty(ref _verticalToHorizontalTime, value);
		}

		[Ordinal(4)] 
		[RED("frontEdgePosition")] 
		public Vector4 FrontEdgePosition
		{
			get => GetProperty(ref _frontEdgePosition);
			set => SetProperty(ref _frontEdgePosition, value);
		}

		[Ordinal(5)] 
		[RED("frontEdgeNormal")] 
		public Vector4 FrontEdgeNormal
		{
			get => GetProperty(ref _frontEdgeNormal);
			set => SetProperty(ref _frontEdgeNormal, value);
		}

		[Ordinal(6)] 
		[RED("yawAngle")] 
		public CFloat YawAngle
		{
			get => GetProperty(ref _yawAngle);
			set => SetProperty(ref _yawAngle, value);
		}

		[Ordinal(7)] 
		[RED("stateLength")] 
		public CFloat StateLength
		{
			get => GetProperty(ref _stateLength);
			set => SetProperty(ref _stateLength, value);
		}

		[Ordinal(8)] 
		[RED("climbType")] 
		public CInt32 ClimbType
		{
			get => GetProperty(ref _climbType);
			set => SetProperty(ref _climbType, value);
		}

		[Ordinal(9)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public animAnimFeature_Climb(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
