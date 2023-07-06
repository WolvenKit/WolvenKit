using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questElevator_ManageNPCAttachment_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questElevator_ManageNPCAttachment_NodeTypeParams> Params
		{
			get => GetPropertyValue<CArray<questElevator_ManageNPCAttachment_NodeTypeParams>>();
			set => SetPropertyValue<CArray<questElevator_ManageNPCAttachment_NodeTypeParams>>(value);
		}

		public questElevator_ManageNPCAttachment_NodeType()
		{
			Params = new() { new questElevator_ManageNPCAttachment_NodeTypeParams() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
