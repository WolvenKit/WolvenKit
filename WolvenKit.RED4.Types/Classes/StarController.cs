using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StarController : inkWidgetLogicController
	{
		private inkWidgetReference _bountyBadgeWidget;

		[Ordinal(1)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get => GetProperty(ref _bountyBadgeWidget);
			set => SetProperty(ref _bountyBadgeWidget, value);
		}
	}
}
