using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceLinkComponentPS : SharedGameplayPS
	{
		private DeviceLink _parentDevice;
		private CBool _isConnected;
		private entEntityID _ownerEntityID;

		[Ordinal(21)] 
		[RED("parentDevice")] 
		public DeviceLink ParentDevice
		{
			get
			{
				if (_parentDevice == null)
				{
					_parentDevice = (DeviceLink) CR2WTypeManager.Create("DeviceLink", "parentDevice", cr2w, this);
				}
				return _parentDevice;
			}
			set
			{
				if (_parentDevice == value)
				{
					return;
				}
				_parentDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get
			{
				if (_isConnected == null)
				{
					_isConnected = (CBool) CR2WTypeManager.Create("Bool", "isConnected", cr2w, this);
				}
				return _isConnected;
			}
			set
			{
				if (_isConnected == value)
				{
					return;
				}
				_isConnected = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get
			{
				if (_ownerEntityID == null)
				{
					_ownerEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerEntityID", cr2w, this);
				}
				return _ownerEntityID;
			}
			set
			{
				if (_ownerEntityID == value)
				{
					return;
				}
				_ownerEntityID = value;
				PropertySet(this);
			}
		}

		public DeviceLinkComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
