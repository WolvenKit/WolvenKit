using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerManageBinkComponent_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questEntityManagerManageBinkComponent_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questEntityManagerManageBinkComponent_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questEntityManagerManageBinkComponent_NodeTypeParams>>(value);
		}

		public questEntityManagerManageBinkComponent_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
