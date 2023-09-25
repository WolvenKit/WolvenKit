using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public GogRewardsController()
		{
			ContainerWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
