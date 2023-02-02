using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameChangeDestination : gameActionInternalEvent
	{
		[Ordinal(0)] 
		[RED("destination")] 
		public Vector4 Destination
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameChangeDestination()
		{
			Destination = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
