using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraCompensationAreaSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("automated")] 
		public CBool Automated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CameraCompensationAreaSettings()
		{
			ISO = 100;
			ShutterTime = 125.000000F;
			FStop = 8.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
