using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerSetMeshAppearance_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questEntityManagerSetMeshAppearance_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questEntityManagerSetMeshAppearance_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questEntityManagerSetMeshAppearance_NodeTypeParams>>(value);
		}

		public questEntityManagerSetMeshAppearance_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
