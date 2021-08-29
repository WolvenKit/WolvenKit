using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDeviceManager_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CArray<CHandle<questDeviceManager_NodeTypeParams>> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questDeviceManager_NodeTypeParams>> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
