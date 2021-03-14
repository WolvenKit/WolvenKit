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
			get
			{
				if (_owner == null)
				{
					_owner = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("globalActions")] 
		public CArray<CHandle<gamedeviceAction>> GlobalActions
		{
			get
			{
				if (_globalActions == null)
				{
					_globalActions = (CArray<CHandle<gamedeviceAction>>) CR2WTypeManager.Create("array:handle:gamedeviceAction", "globalActions", cr2w, this);
				}
				return _globalActions;
			}
			set
			{
				if (_globalActions == value)
				{
					return;
				}
				_globalActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get
			{
				if (_context == null)
				{
					_context = (gameGetActionsContext) CR2WTypeManager.Create("gameGetActionsContext", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("connectedDevices")] 
		public CArray<CHandle<gameDeviceComponentPS>> ConnectedDevices
		{
			get
			{
				if (_connectedDevices == null)
				{
					_connectedDevices = (CArray<CHandle<gameDeviceComponentPS>>) CR2WTypeManager.Create("array:handle:gameDeviceComponentPS", "connectedDevices", cr2w, this);
				}
				return _connectedDevices;
			}
			set
			{
				if (_connectedDevices == value)
				{
					return;
				}
				_connectedDevices = value;
				PropertySet(this);
			}
		}

		public VirtualMasterDevicePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
