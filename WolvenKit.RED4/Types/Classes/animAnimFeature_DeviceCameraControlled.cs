using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_DeviceCameraControlled : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("currentRotation")] 
		public Vector4 CurrentRotation
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_DeviceCameraControlled()
		{
			CurrentRotation = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
