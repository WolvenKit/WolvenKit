using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiEntityPreviewCameraSettings : RedBaseClass
	{
		private CBool _autoEnable;
		private CEnum<ERenderingMode> _renderingMode;
		private CFloat _panSpeed;
		private EulerAngles _rotationSpeed;
		private EulerAngles _rotationMin;
		private EulerAngles _rotationMax;
		private EulerAngles _rotationDefault;
		private CFloat _zoomSpeed;
		private CFloat _zoomMin;
		private CFloat _zoomMax;
		private CFloat _zoomDefault;

		[Ordinal(0)] 
		[RED("autoEnable")] 
		public CBool AutoEnable
		{
			get => GetProperty(ref _autoEnable);
			set => SetProperty(ref _autoEnable, value);
		}

		[Ordinal(1)] 
		[RED("renderingMode")] 
		public CEnum<ERenderingMode> RenderingMode
		{
			get => GetProperty(ref _renderingMode);
			set => SetProperty(ref _renderingMode, value);
		}

		[Ordinal(2)] 
		[RED("panSpeed")] 
		public CFloat PanSpeed
		{
			get => GetProperty(ref _panSpeed);
			set => SetProperty(ref _panSpeed, value);
		}

		[Ordinal(3)] 
		[RED("rotationSpeed")] 
		public EulerAngles RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}

		[Ordinal(4)] 
		[RED("rotationMin")] 
		public EulerAngles RotationMin
		{
			get => GetProperty(ref _rotationMin);
			set => SetProperty(ref _rotationMin, value);
		}

		[Ordinal(5)] 
		[RED("rotationMax")] 
		public EulerAngles RotationMax
		{
			get => GetProperty(ref _rotationMax);
			set => SetProperty(ref _rotationMax, value);
		}

		[Ordinal(6)] 
		[RED("rotationDefault")] 
		public EulerAngles RotationDefault
		{
			get => GetProperty(ref _rotationDefault);
			set => SetProperty(ref _rotationDefault, value);
		}

		[Ordinal(7)] 
		[RED("zoomSpeed")] 
		public CFloat ZoomSpeed
		{
			get => GetProperty(ref _zoomSpeed);
			set => SetProperty(ref _zoomSpeed, value);
		}

		[Ordinal(8)] 
		[RED("zoomMin")] 
		public CFloat ZoomMin
		{
			get => GetProperty(ref _zoomMin);
			set => SetProperty(ref _zoomMin, value);
		}

		[Ordinal(9)] 
		[RED("zoomMax")] 
		public CFloat ZoomMax
		{
			get => GetProperty(ref _zoomMax);
			set => SetProperty(ref _zoomMax, value);
		}

		[Ordinal(10)] 
		[RED("zoomDefault")] 
		public CFloat ZoomDefault
		{
			get => GetProperty(ref _zoomDefault);
			set => SetProperty(ref _zoomDefault, value);
		}

		public gameuiEntityPreviewCameraSettings()
		{
			_panSpeed = 0.500000F;
			_zoomSpeed = 0.500000F;
			_zoomMin = 25.000000F;
			_zoomMax = 100.000000F;
			_zoomDefault = 50.000000F;
		}
	}
}
