using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTransferItem_NodeType : questIItemManagerNodeType
	{
		private CArray<questTransferItems_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questTransferItems_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
