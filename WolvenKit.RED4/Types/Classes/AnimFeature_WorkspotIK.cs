using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_WorkspotIK : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("rightHandPosition")] 
		public Vector4 RightHandPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("leftHandPosition")] 
		public Vector4 LeftHandPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("cameraPosition")] 
		public Vector4 CameraPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("rightHandRotation")] 
		public Quaternion RightHandRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(4)] 
		[RED("leftHandRotation")] 
		public Quaternion LeftHandRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(5)] 
		[RED("cameraRotation")] 
		public Quaternion CameraRotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(6)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isInteractingWithDevice")] 
		public CBool IsInteractingWithDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_WorkspotIK()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
