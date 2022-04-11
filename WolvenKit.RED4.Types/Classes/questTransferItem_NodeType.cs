using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransferItem_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questTransferItems_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questTransferItems_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questTransferItems_NodeTypeParams>>(value);
		}

		public questTransferItem_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
