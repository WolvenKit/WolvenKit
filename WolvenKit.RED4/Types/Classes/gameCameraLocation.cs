using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCameraLocation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public EulerAngles Rotation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		public gameCameraLocation()
		{
			Position = new();
			Rotation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
