using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FrameWidgetComponent : WorldWidgetComponent
	{
		[Ordinal(20)] 
		[RED("dimensions")] 
		public Vector2 Dimensions
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public FrameWidgetComponent()
		{
			Dimensions = new Vector2 { X = 100.000000F, Y = 100.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
