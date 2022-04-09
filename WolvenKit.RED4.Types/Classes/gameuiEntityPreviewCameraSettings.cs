using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiEntityPreviewCameraSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("autoEnable")] 
		public CBool AutoEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("renderingMode")] 
		public CEnum<ERenderingMode> RenderingMode
		{
			get => GetPropertyValue<CEnum<ERenderingMode>>();
			set => SetPropertyValue<CEnum<ERenderingMode>>(value);
		}

		[Ordinal(2)] 
		[RED("panSpeed")] 
		public CFloat PanSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("rotationSpeed")] 
		public EulerAngles RotationSpeed
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(4)] 
		[RED("rotationMin")] 
		public EulerAngles RotationMin
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(5)] 
		[RED("rotationMax")] 
		public EulerAngles RotationMax
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(6)] 
		[RED("rotationDefault")] 
		public EulerAngles RotationDefault
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(7)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("zoomMin")] 
		public CFloat ZoomMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("zoomMax")] 
		public CFloat ZoomMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("zoomDefault")] 
		public CFloat ZoomDefault
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiEntityPreviewCameraSettings()
		{
			PanSpeed = 0.500000F;
			RotationSpeed = new() { Pitch = 1.250000F, Yaw = 1.250000F };
			RotationMin = new() { Pitch = -85.000000F, Yaw = -360.000000F };
			RotationMax = new() { Pitch = -10.000000F, Yaw = 360.000000F };
			RotationDefault = new() { Pitch = -70.000000F, Yaw = -90.000000F };
			ZoomSpeed = 0.500000F;
			ZoomMin = 25.000000F;
			ZoomMax = 100.000000F;
			ZoomDefault = 50.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
