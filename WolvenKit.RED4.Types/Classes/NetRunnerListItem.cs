using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetRunnerListItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public NetRunnerListItem()
		{
			Highlight = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
