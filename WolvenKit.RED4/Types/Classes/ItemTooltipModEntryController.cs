using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipModEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipModEntryController()
		{
			ModName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
