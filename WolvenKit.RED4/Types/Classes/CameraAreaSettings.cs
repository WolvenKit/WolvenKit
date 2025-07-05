using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("cameraNearPlane")] 
		public CFloat CameraNearPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cameraFarPlane")] 
		public CFloat CameraFarPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("automated")] 
		public CBool Automated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CameraAreaSettings()
		{
			Enable = true;
			CameraNearPlane = 0.400000F;
			CameraFarPlane = 8000.000000F;
			ISO = 100;
			ShutterTime = 125.000000F;
			FStop = 8.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
