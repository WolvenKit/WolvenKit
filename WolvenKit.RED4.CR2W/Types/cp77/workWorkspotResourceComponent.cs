using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResourceComponent : entIPlacedComponent
	{
		private rRef<workWorkspotResource> _resource;
		private rRef<workWorkspotResource> _npcResource;
		private rRef<workWorkspotResource> _deviceResource;
		private CName _syncSlotName;
		private CBool _shouldCrouch;

		[Ordinal(5)] 
		[RED("resource")] 
		public rRef<workWorkspotResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("npcResource")] 
		public rRef<workWorkspotResource> NpcResource
		{
			get
			{
				if (_npcResource == null)
				{
					_npcResource = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "npcResource", cr2w, this);
				}
				return _npcResource;
			}
			set
			{
				if (_npcResource == value)
				{
					return;
				}
				_npcResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deviceResource")] 
		public rRef<workWorkspotResource> DeviceResource
		{
			get
			{
				if (_deviceResource == null)
				{
					_deviceResource = (rRef<workWorkspotResource>) CR2WTypeManager.Create("rRef:workWorkspotResource", "deviceResource", cr2w, this);
				}
				return _deviceResource;
			}
			set
			{
				if (_deviceResource == value)
				{
					return;
				}
				_deviceResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("syncSlotName")] 
		public CName SyncSlotName
		{
			get
			{
				if (_syncSlotName == null)
				{
					_syncSlotName = (CName) CR2WTypeManager.Create("CName", "syncSlotName", cr2w, this);
				}
				return _syncSlotName;
			}
			set
			{
				if (_syncSlotName == value)
				{
					return;
				}
				_syncSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get
			{
				if (_shouldCrouch == null)
				{
					_shouldCrouch = (CBool) CR2WTypeManager.Create("Bool", "shouldCrouch", cr2w, this);
				}
				return _shouldCrouch;
			}
			set
			{
				if (_shouldCrouch == value)
				{
					return;
				}
				_shouldCrouch = value;
				PropertySet(this);
			}
		}

		public workWorkspotResourceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
