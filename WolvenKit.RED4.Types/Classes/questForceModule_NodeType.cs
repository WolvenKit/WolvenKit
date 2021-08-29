using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questForceModule_NodeType : questIVisionModeNodeType
	{
		private CArray<questForceVMModule_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questForceVMModule_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
