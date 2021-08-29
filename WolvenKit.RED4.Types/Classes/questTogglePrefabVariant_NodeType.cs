using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTogglePrefabVariant_NodeType : questIWorldDataManagerNodeType
	{
		private CArray<questTogglePrefabVariant_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questTogglePrefabVariant_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
