using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputActionLook : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("rotation")] 
		public Vector2 Rotation
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameMuppetInputActionLook()
		{
			Rotation = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
