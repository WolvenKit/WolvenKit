using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardsGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public GogRewardsGroupController()
		{
			Label = new inkTextWidgetReference();
			ContainerWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
