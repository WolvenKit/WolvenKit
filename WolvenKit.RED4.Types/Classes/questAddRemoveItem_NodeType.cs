using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAddRemoveItem_NodeType : questIItemManagerNodeType
	{
		private CArray<CHandle<questAddRemoveItem_NodeTypeParams>> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questAddRemoveItem_NodeTypeParams>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
