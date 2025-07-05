using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetItemTags_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetItemTags_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questSetItemTags_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questSetItemTags_NodeTypeParams>>(value);
		}

		public questSetItemTags_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
