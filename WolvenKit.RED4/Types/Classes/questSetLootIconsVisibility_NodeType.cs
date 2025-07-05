using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetLootIconsVisibility_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("lootIconsVisible")] 
		public CBool LootIconsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetLootIconsVisibility_NodeType()
		{
			LootIconsVisible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
