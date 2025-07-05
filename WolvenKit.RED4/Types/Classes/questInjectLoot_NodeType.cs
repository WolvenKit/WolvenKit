using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInjectLoot_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questInjectLoot_NodeTypeParams>> Params
		{
			get => GetPropertyValue<CArray<CHandle<questInjectLoot_NodeTypeParams>>>();
			set => SetPropertyValue<CArray<CHandle<questInjectLoot_NodeTypeParams>>>(value);
		}

		public questInjectLoot_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
