using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksLevelBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("foregroundImage")] 
		public inkWidgetReference ForegroundImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("backgroundImage")] 
		public inkWidgetReference BackgroundImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PerksLevelBarController()
		{
			ForegroundImage = new();
			BackgroundImage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
