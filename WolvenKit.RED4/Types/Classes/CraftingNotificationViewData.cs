using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftingNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CraftingNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
