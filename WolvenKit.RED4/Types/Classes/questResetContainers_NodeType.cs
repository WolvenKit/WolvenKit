using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questResetContainers_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questResetContainers_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questResetContainers_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questResetContainers_NodeTypeParams>>(value);
		}

		public questResetContainers_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
