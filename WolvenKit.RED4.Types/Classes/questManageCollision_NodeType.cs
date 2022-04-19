using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questManageCollision_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questManageCollision_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questManageCollision_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questManageCollision_NodeTypeParams>>(value);
		}

		public questManageCollision_NodeType()
		{
			Params = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
