using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEnvironmentDamageReceiverBox : gameEnvironmentDamageReceiverShape
	{
		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameEnvironmentDamageReceiverBox()
		{
			Transform = new Transform();
			Dimensions = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
