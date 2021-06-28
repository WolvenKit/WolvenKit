using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualMasterDevicePS : ScriptableDeviceComponentPS
	{
		private CHandle<IScriptable> _owner;
		private CArray<CHandle<gamedeviceAction>> _globalActions;
		private gameGetActionsContext _context;
		private CArray<CHandle<gameDeviceComponentPS>> _connectedDevices;

		[Ordinal(103)] 
		[RED("owner")] 
		public CHandle<IScriptable> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(104)] 
		[RED("globalActions")] 
		public CArray<CHandle<gamedeviceAction>> GlobalActions
		{
			get => GetProperty(ref _globalActions);
			set => SetProperty(ref _globalActions, value);
		}

		[Ordinal(105)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(106)] 
		[RED("connectedDevices")] 
		public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices
		{
			get => GetProperty(ref _connectedDevices);
			set => SetProperty(ref _connectedDevices, value);
		}

		public VirtualMasterDevicePS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
