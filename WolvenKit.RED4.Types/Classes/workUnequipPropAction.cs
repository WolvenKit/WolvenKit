using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workUnequipPropAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workUnequipPropAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
