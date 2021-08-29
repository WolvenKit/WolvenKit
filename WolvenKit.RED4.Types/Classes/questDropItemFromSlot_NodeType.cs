using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDropItemFromSlot_NodeType : questIItemManagerNodeType
	{
		private CArray<questDropItemFromSlot_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questDropItemFromSlot_NodeTypeParams> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
