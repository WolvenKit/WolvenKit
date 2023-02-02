using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTogglePrefabVariant_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questTogglePrefabVariant_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questTogglePrefabVariant_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questTogglePrefabVariant_NodeTypeParams>>(value);
		}

		public questTogglePrefabVariant_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
