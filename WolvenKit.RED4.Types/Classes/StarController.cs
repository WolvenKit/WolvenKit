using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public StarController()
		{
			BountyBadgeWidget = new();
		}
	}
}
