using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDropItemFromSlot_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questDropItemFromSlot_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questDropItemFromSlot_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questDropItemFromSlot_NodeTypeParams>>(value);
		}

		public questDropItemFromSlot_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
