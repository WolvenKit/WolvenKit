using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceScanningDescription : ObjectScanningDescription
	{
		private TweakDBID _deviceGameplayDescription;
		private CArray<TweakDBID> _deviceCustomDescriptions;
		private TweakDBID _deviceGameplayRole;
		private CArray<TweakDBID> _deviceRoleActionsDescriptions;

		[Ordinal(0)] 
		[RED("DeviceGameplayDescription")] 
		public TweakDBID DeviceGameplayDescription
		{
			get
			{
				if (_deviceGameplayDescription == null)
				{
					_deviceGameplayDescription = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "DeviceGameplayDescription", cr2w, this);
				}
				return _deviceGameplayDescription;
			}
			set
			{
				if (_deviceGameplayDescription == value)
				{
					return;
				}
				_deviceGameplayDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DeviceCustomDescriptions")] 
		public CArray<TweakDBID> DeviceCustomDescriptions
		{
			get
			{
				if (_deviceCustomDescriptions == null)
				{
					_deviceCustomDescriptions = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "DeviceCustomDescriptions", cr2w, this);
				}
				return _deviceCustomDescriptions;
			}
			set
			{
				if (_deviceCustomDescriptions == value)
				{
					return;
				}
				_deviceCustomDescriptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DeviceGameplayRole")] 
		public TweakDBID DeviceGameplayRole
		{
			get
			{
				if (_deviceGameplayRole == null)
				{
					_deviceGameplayRole = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "DeviceGameplayRole", cr2w, this);
				}
				return _deviceGameplayRole;
			}
			set
			{
				if (_deviceGameplayRole == value)
				{
					return;
				}
				_deviceGameplayRole = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DeviceRoleActionsDescriptions")] 
		public CArray<TweakDBID> DeviceRoleActionsDescriptions
		{
			get
			{
				if (_deviceRoleActionsDescriptions == null)
				{
					_deviceRoleActionsDescriptions = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "DeviceRoleActionsDescriptions", cr2w, this);
				}
				return _deviceRoleActionsDescriptions;
			}
			set
			{
				if (_deviceRoleActionsDescriptions == value)
				{
					return;
				}
				_deviceRoleActionsDescriptions = value;
				PropertySet(this);
			}
		}

		public DeviceScanningDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
