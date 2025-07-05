using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questReInitContainers_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questReInitContainers_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questReInitContainers_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questReInitContainers_NodeTypeParams>>(value);
		}

		public questReInitContainers_NodeType()
		{
			Params = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
