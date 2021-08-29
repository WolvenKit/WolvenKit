using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTimeDilation_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CArray<CHandle<questTimeDilation_NodeTypeParam>> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questTimeDilation_NodeTypeParam>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
