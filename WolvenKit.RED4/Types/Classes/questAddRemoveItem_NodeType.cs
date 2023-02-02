using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAddRemoveItem_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questAddRemoveItem_NodeTypeParams>> Params
		{
			get => GetPropertyValue<CArray<CHandle<questAddRemoveItem_NodeTypeParams>>>();
			set => SetPropertyValue<CArray<CHandle<questAddRemoveItem_NodeTypeParams>>>(value);
		}

		public questAddRemoveItem_NodeType()
		{
			Params = new() { null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
