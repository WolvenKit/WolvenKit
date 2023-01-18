using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVirtualCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("resolutionWidth")] 
		public CUInt32 ResolutionWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("resolutionHeight")] 
		public CUInt32 ResolutionHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("drawBackground")] 
		public CBool DrawBackground
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entVirtualCameraComponent()
		{
			Fov = 75.000000F;
			NearPlaneOverride = 0.100000F;
			FarPlaneOverride = 1000.000000F;
			VirtualCameraName = "Component";
			ResolutionWidth = 1920;
			ResolutionHeight = 1080;
			DrawBackground = true;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
