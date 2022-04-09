using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRandomNewsFeedAnimator : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiRandomNewsFeedAnimator()
		{
			TextWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
