using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netFrameInputs : CVariable
	{
		private CArray<netInputAction> _inputBuffer;
		private netTime _timestamp;
		private CFloat _cameraRotationYaw;
		private CFloat _cameraRotationPitch;
		private CFloat _lookAtRotationYaw;
		private CFloat _lookAtRotationPitch;
		private CFloat _timeDelta;

		[Ordinal(0)] 
		[RED("inputBuffer")] 
		public CArray<netInputAction> InputBuffer
		{
			get => GetProperty(ref _inputBuffer);
			set => SetProperty(ref _inputBuffer, value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public netTime Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		[Ordinal(2)] 
		[RED("cameraRotationYaw")] 
		public CFloat CameraRotationYaw
		{
			get => GetProperty(ref _cameraRotationYaw);
			set => SetProperty(ref _cameraRotationYaw, value);
		}

		[Ordinal(3)] 
		[RED("cameraRotationPitch")] 
		public CFloat CameraRotationPitch
		{
			get => GetProperty(ref _cameraRotationPitch);
			set => SetProperty(ref _cameraRotationPitch, value);
		}

		[Ordinal(4)] 
		[RED("lookAtRotationYaw")] 
		public CFloat LookAtRotationYaw
		{
			get => GetProperty(ref _lookAtRotationYaw);
			set => SetProperty(ref _lookAtRotationYaw, value);
		}

		[Ordinal(5)] 
		[RED("lookAtRotationPitch")] 
		public CFloat LookAtRotationPitch
		{
			get => GetProperty(ref _lookAtRotationPitch);
			set => SetProperty(ref _lookAtRotationPitch, value);
		}

		[Ordinal(6)] 
		[RED("timeDelta")] 
		public CFloat TimeDelta
		{
			get => GetProperty(ref _timeDelta);
			set => SetProperty(ref _timeDelta, value);
		}

		public netFrameInputs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
