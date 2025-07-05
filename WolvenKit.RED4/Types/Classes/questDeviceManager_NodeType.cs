using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDeviceManager_NodeType : questIInteractiveObjectManagerNodeType
	{
		[Ordinal(0)] 
		[RED("params")] 
		public CArray<CHandle<questDeviceManager_NodeTypeParams>> Params
		{
			get => GetPropertyValue<CArray<CHandle<questDeviceManager_NodeTypeParams>>>();
			set => SetPropertyValue<CArray<CHandle<questDeviceManager_NodeTypeParams>>>(value);
		}

		public questDeviceManager_NodeType()
		{
			Params = new() { null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
