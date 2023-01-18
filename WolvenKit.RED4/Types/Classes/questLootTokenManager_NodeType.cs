using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLootTokenManager_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questLootTokenManager_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questLootTokenManager_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questLootTokenManager_NodeTypeParams>>(value);
		}

		public questLootTokenManager_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
