using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("owner")] 
		public CHandle<IScriptable> Owner
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(105)] 
		[RED("globalActions")] 
		public CArray<CHandle<gamedeviceAction>> GlobalActions
		{
			get => GetPropertyValue<CArray<CHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<gamedeviceAction>>>(value);
		}

		[Ordinal(106)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetPropertyValue<gameGetActionsContext>();
			set => SetPropertyValue<gameGetActionsContext>(value);
		}

		[Ordinal(107)] 
		[RED("connectedDevices")] 
		public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices
		{
			get => GetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>();
			set => SetPropertyValue<CArray<CHandle<gameDeviceComponentPS>>>(value);
		}

		public VirtualMasterDevicePS()
		{
			GlobalActions = new();
			Context = new gameGetActionsContext { RequestorID = new entEntityID(), ActionPrereqs = new() };
			ConnectedDevices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
