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
			Destination = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
