using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSSlotActiveItems : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rightHandItem")] 
		public gameItemID RightHandItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("leftHandItem")] 
		public gameItemID LeftHandItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameSSlotActiveItems()
		{
			RightHandItem = new();
			LeftHandItem = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
