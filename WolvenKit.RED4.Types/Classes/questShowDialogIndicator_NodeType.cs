using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowDialogIndicator_NodeType : questIUIManagerNodeType
	{
		private CArray<questShowDialogIndicator_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questShowDialogIndicator_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
