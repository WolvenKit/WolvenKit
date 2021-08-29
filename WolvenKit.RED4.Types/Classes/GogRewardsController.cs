using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GogRewardsController : inkWidgetLogicController
	{
		private inkWidgetReference _containerWidget;

		[Ordinal(1)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetProperty(ref _containerWidget);
			set => SetProperty(ref _containerWidget, value);
		}
	}
}
