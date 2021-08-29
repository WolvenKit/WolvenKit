using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInjectLoot_NodeType : questIItemManagerNodeType
	{
		private CArray<questInjectLoot_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questInjectLoot_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
