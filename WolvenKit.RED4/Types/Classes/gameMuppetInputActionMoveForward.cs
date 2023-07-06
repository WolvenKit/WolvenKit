using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputActionMoveForward : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("direction")] 
		public Vector2 Direction
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("isSprinting")] 
		public CBool IsSprinting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMuppetInputActionMoveForward()
		{
			Direction = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
