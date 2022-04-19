using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetDestinationActionEvent : gameActionEvent
	{
		[Ordinal(4)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameSetDestinationActionEvent()
		{
			Position = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
