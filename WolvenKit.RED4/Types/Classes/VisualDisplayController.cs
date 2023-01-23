using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VisualDisplayController : InventoryItemDisplayController
	{
		[Ordinal(99)] 
		[RED("equipped")] 
		public CBool Equipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VisualDisplayController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
