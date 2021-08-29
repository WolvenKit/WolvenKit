using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		private CHandle<IScriptable> _owner;
		private CArray<CHandle<gamedeviceAction>> _globalActions;
		private gameGetActionsContext _context;
		private CArray<CHandle<gameDeviceComponentPS>> _connectedDevices;

		[Ordinal(104)] 
		[RED("owner")] 
		public CHandle<IScriptable> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(105)] 
		[RED("globalActions")] 
		public CArray<CHandle<gamedeviceAction>> GlobalActions
		{
			get => GetProperty(ref _globalActions);
			set => SetProperty(ref _globalActions, value);
		}

		[Ordinal(106)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(107)] 
		[RED("connectedDevices")] 
		public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices
		{
			get => GetProperty(ref _connectedDevices);
			set => SetProperty(ref _connectedDevices, value);
		}
	}
}
