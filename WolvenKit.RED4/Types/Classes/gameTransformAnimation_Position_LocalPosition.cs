using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Position_LocalPosition : gameTransformAnimation_Position
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameTransformAnimation_Position_LocalPosition()
		{
			Position = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
