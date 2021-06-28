using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetCameraParamsWithOverridesEvent : redEvent
	{
		private CName _paramsName;
		private CFloat _yawMaxLeft;
		private CFloat _yawMaxRight;
		private CFloat _pitchMax;
		private CFloat _pitchMin;
		private CFloat _sensitivityMultX;
		private CFloat _sensitivityMultY;

		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get => GetProperty(ref _paramsName);
			set => SetProperty(ref _paramsName, value);
		}

		[Ordinal(1)] 
		[RED("yawMaxLeft")] 
		public CFloat YawMaxLeft
		{
			get => GetProperty(ref _yawMaxLeft);
			set => SetProperty(ref _yawMaxLeft, value);
		}

		[Ordinal(2)] 
		[RED("yawMaxRight")] 
		public CFloat YawMaxRight
		{
			get => GetProperty(ref _yawMaxRight);
			set => SetProperty(ref _yawMaxRight, value);
		}

		[Ordinal(3)] 
		[RED("pitchMax")] 
		public CFloat PitchMax
		{
			get => GetProperty(ref _pitchMax);
			set => SetProperty(ref _pitchMax, value);
		}

		[Ordinal(4)] 
		[RED("pitchMin")] 
		public CFloat PitchMin
		{
			get => GetProperty(ref _pitchMin);
			set => SetProperty(ref _pitchMin, value);
		}

		[Ordinal(5)] 
		[RED("sensitivityMultX")] 
		public CFloat SensitivityMultX
		{
			get => GetProperty(ref _sensitivityMultX);
			set => SetProperty(ref _sensitivityMultX, value);
		}

		[Ordinal(6)] 
		[RED("sensitivityMultY")] 
		public CFloat SensitivityMultY
		{
			get => GetProperty(ref _sensitivityMultY);
			set => SetProperty(ref _sensitivityMultY, value);
		}

		public gameSetCameraParamsWithOverridesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
