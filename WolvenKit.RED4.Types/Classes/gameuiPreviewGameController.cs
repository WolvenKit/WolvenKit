using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPreviewGameController : gameuiMenuGameController
	{
		private CFloat _yawSpeed;
		private CFloat _yawDefault;
		private CBool _isRotatable;
		private CFloat _rotationSpeed;

		[Ordinal(3)] 
		[RED("yawSpeed")] 
		public CFloat YawSpeed
		{
			get => GetProperty(ref _yawSpeed);
			set => SetProperty(ref _yawSpeed, value);
		}

		[Ordinal(4)] 
		[RED("yawDefault")] 
		public CFloat YawDefault
		{
			get => GetProperty(ref _yawDefault);
			set => SetProperty(ref _yawDefault, value);
		}

		[Ordinal(5)] 
		[RED("isRotatable")] 
		public CBool IsRotatable
		{
			get => GetProperty(ref _isRotatable);
			set => SetProperty(ref _isRotatable, value);
		}

		[Ordinal(6)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get => GetProperty(ref _rotationSpeed);
			set => SetProperty(ref _rotationSpeed, value);
		}
	}
}
