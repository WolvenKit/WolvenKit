using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_String _displayString;
		private gamebbScriptID_Bool _enableActions;
		private gamebbScriptID_Variant _status;

		[Ordinal(7)] 
		[RED("DisplayString")] 
		public gamebbScriptID_String DisplayString
		{
			get
			{
				if (_displayString == null)
				{
					_displayString = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "DisplayString", cr2w, this);
				}
				return _displayString;
			}
			set
			{
				if (_displayString == value)
				{
					return;
				}
				_displayString = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("EnableActions")] 
		public gamebbScriptID_Bool EnableActions
		{
			get
			{
				if (_enableActions == null)
				{
					_enableActions = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "EnableActions", cr2w, this);
				}
				return _enableActions;
			}
			set
			{
				if (_enableActions == value)
				{
					return;
				}
				_enableActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Status")] 
		public gamebbScriptID_Variant Status
		{
			get
			{
				if (_status == null)
				{
					_status = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		public IntercomBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
