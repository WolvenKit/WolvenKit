using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workUnequipPropAction : workIWorkspotItemAction
	{
		[Ordinal(0)] 
		[RED("itemId")] 
		public CName ItemId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
