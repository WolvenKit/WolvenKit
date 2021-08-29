using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_DeviceCameraControlled : animAnimFeature
	{
		private Vector4 _currentRotation;

		[Ordinal(0)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get => GetProperty(ref _currentRotation);
			set => SetProperty(ref _currentRotation, value);
		}
	}
}
