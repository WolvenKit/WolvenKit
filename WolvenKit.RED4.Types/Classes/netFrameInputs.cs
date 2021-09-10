using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netFrameInputs : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inputBuffer")] 
		public CArray<netInputAction> InputBuffer
		{
			get => GetPropertyValue<CArray<netInputAction>>();
			set => SetPropertyValue<CArray<netInputAction>>(value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public netTime Timestamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(2)] 
		[RED("cameraRotationYaw")] 
		public CFloat CameraRotationYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cameraRotationPitch")] 
		public CFloat CameraRotationPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lookAtRotationYaw")] 
		public CFloat LookAtRotationYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("lookAtRotationPitch")] 
		public CFloat LookAtRotationPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeDelta")] 
		public CFloat TimeDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public netFrameInputs()
		{
			InputBuffer = new();
			Timestamp = new();
		}
	}
}
