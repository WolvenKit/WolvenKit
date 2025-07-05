using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveAllPerks : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("unequipPerkItems")] 
		public CBool UnequipPerkItems
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("removeCost")] 
		public CBool RemoveCost
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RemoveAllPerks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
