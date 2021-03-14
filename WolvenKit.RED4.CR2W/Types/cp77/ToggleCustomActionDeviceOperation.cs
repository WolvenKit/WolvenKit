using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		private CName _customActionID;
		private CBool _enabled;

		[Ordinal(5)] 
		[RED("customActionID")] 
		public CName CustomActionID
		{
			get
			{
				if (_customActionID == null)
				{
					_customActionID = (CName) CR2WTypeManager.Create("CName", "customActionID", cr2w, this);
				}
				return _customActionID;
			}
			set
			{
				if (_customActionID == value)
				{
					return;
				}
				_customActionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		public ToggleCustomActionDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
