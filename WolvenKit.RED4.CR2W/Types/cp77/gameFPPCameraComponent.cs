using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponent : gameCameraComponent
	{
		private CFloat _pitchMin;
		private CFloat _pitchMax;
		private CFloat _yawMaxLeft;
		private CFloat _yawMaxRight;
		private CBool _headingLocked;
		private CFloat _sensitivityMultX;
		private CFloat _sensitivityMultY;
		private CName _timeDilationCurveName;

		[Ordinal(35)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get => GetProperty(ref _pitchMin);
			set => SetProperty(ref _pitchMin, value);
		}

		[Ordinal(36)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get => GetProperty(ref _pitchMax);
			set => SetProperty(ref _pitchMax, value);
		}

		[Ordinal(37)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get => GetProperty(ref _yawMaxLeft);
			set => SetProperty(ref _yawMaxLeft, value);
		}

		[Ordinal(38)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get => GetProperty(ref _yawMaxRight);
			set => SetProperty(ref _yawMaxRight, value);
		}

		[Ordinal(39)] 
		[RED("headingLocked")] 
		public CBool HeadingLocked
		{
			get => GetProperty(ref _headingLocked);
			set => SetProperty(ref _headingLocked, value);
		}

		[Ordinal(40)] 
		[RED("sensitivityMultX")] 
		public CFloat SensitivityMultX
		{
			get => GetProperty(ref _sensitivityMultX);
			set => SetProperty(ref _sensitivityMultX, value);
		}

		[Ordinal(41)] 
		[RED("sensitivityMultY")] 
		public CFloat SensitivityMultY
		{
			get => GetProperty(ref _sensitivityMultY);
			set => SetProperty(ref _sensitivityMultY, value);
		}

		[Ordinal(42)] 
		[RED("timeDilationCurveName")] 
		public CName TimeDilationCurveName
		{
			get => GetProperty(ref _timeDilationCurveName);
			set => SetProperty(ref _timeDilationCurveName, value);
		}

		public gameFPPCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
