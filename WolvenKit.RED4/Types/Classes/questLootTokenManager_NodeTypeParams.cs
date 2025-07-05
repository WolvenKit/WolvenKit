using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLootTokenManager_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tokenNodeRef")] 
		public NodeRef TokenNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("lootTokenState")] 
		public CEnum<questLootTokenState> LootTokenState
		{
			get => GetPropertyValue<CEnum<questLootTokenState>>();
			set => SetPropertyValue<CEnum<questLootTokenState>>(value);
		}

		public questLootTokenManager_NodeTypeParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
