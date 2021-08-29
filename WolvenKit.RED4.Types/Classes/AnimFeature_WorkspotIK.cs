using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_WorkspotIK : animAnimFeature
	{
		private Vector4 _rightHandPosition;
		private Vector4 _leftHandPosition;
		private Vector4 _cameraPosition;
		private Quaternion _rightHandRotation;
		private Quaternion _leftHandRotation;
		private Quaternion _cameraRotation;
		private CBool _shouldCrouch;
		private CBool _isInteractingWithDevice;

		[Ordinal(0)] 
		[RED("rightHandPosition")] 
		public Vector4 RightHandPosition
		{
			get => GetProperty(ref _rightHandPosition);
			set => SetProperty(ref _rightHandPosition, value);
		}

		[Ordinal(1)] 
		[RED("leftHandPosition")] 
		public Vector4 LeftHandPosition
		{
			get => GetProperty(ref _leftHandPosition);
			set => SetProperty(ref _leftHandPosition, value);
		}

		[Ordinal(2)] 
		[RED("cameraPosition")] 
		public Vector4 CameraPosition
		{
			get => GetProperty(ref _cameraPosition);
			set => SetProperty(ref _cameraPosition, value);
		}

		[Ordinal(3)] 
		[RED("rightHandRotation")] 
		public Quaternion RightHandRotation
		{
			get => GetProperty(ref _rightHandRotation);
			set => SetProperty(ref _rightHandRotation, value);
		}

		[Ordinal(4)] 
		[RED("leftHandRotation")] 
		public Quaternion LeftHandRotation
		{
			get => GetProperty(ref _leftHandRotation);
			set => SetProperty(ref _leftHandRotation, value);
		}

		[Ordinal(5)] 
		[RED("cameraRotation")] 
		public Quaternion CameraRotation
		{
			get => GetProperty(ref _cameraRotation);
			set => SetProperty(ref _cameraRotation, value);
		}

		[Ordinal(6)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get => GetProperty(ref _shouldCrouch);
			set => SetProperty(ref _shouldCrouch, value);
		}

		[Ordinal(7)] 
		[RED("isInteractingWithDevice")] 
		public CBool IsInteractingWithDevice
		{
			get => GetProperty(ref _isInteractingWithDevice);
			set => SetProperty(ref _isInteractingWithDevice, value);
		}
	}
}
