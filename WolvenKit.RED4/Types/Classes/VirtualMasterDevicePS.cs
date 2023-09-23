using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("owner")] 
		public CHandle<IScriptable> Owner
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(108)] 
		[RED("globalActions")] 
		public CArray<CHandle<gamedeviceAction>> GlobalActions
		{
			get => GetPropertyValue<CArray<CHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<gamedeviceAction>>>(value);
		}

		[Ordinal(109)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetPropertyValue<gameGetActionsContext>();
			set => SetPropertyValue<gameGetActionsContext>(value);
		}

		[Ordinal(110)] 
		[RED("connectedDevices")] 
		public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		public VirtualMasterDevicePS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
