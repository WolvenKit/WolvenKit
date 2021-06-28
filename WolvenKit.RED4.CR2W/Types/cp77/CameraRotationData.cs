using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraRotationData : CVariable
	{
		private CFloat _pitch;
		private CFloat _maxPitch;
		private CFloat _minPitch;
		private CFloat _yaw;
		private CFloat _maxYaw;
		private CFloat _minYaw;

		[Ordinal(0)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(1)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get => GetProperty(ref _maxPitch);
			set => SetProperty(ref _maxPitch, value);
		}

		[Ordinal(2)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get => GetProperty(ref _minPitch);
			set => SetProperty(ref _minPitch, value);
		}

		[Ordinal(3)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(4)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get => GetProperty(ref _maxYaw);
			set => SetProperty(ref _maxYaw, value);
		}

		[Ordinal(5)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get => GetProperty(ref _minYaw);
			set => SetProperty(ref _minYaw, value);
		}

		public CameraRotationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
