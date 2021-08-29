using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPreloadFX_NodeType : questIFXManagerNodeType
	{
		private CArray<questPreloadFX_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questPreloadFX_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
