using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLootTokenManager_NodeTypeParams : RedBaseClass
	{
		private NodeRef _tokenNodeRef;
		private CEnum<questLootTokenState> _lootTokenState;

		[Ordinal(0)] 
		[RED("tokenNodeRef")] 
		public NodeRef TokenNodeRef
		{
			get => GetProperty(ref _tokenNodeRef);
			set => SetProperty(ref _tokenNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("lootTokenState")] 
		public CEnum<questLootTokenState> LootTokenState
		{
			get => GetProperty(ref _lootTokenState);
			set => SetProperty(ref _lootTokenState, value);
		}
	}
}
