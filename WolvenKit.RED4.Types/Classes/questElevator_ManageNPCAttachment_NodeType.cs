using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questElevator_ManageNPCAttachment_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CArray<questElevator_ManageNPCAttachment_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questElevator_ManageNPCAttachment_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
