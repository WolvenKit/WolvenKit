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
			Position = new Vector3 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
