using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceBaseBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _actionWidgetsData;
		private gamebbScriptID_Variant _deviceWidgetsData;
		private gamebbScriptID_Bool _uIupdate;
		private gamebbScriptID_Variant _breadCrumbElement;
		private gamebbScriptID_Variant _glitchData;
		private gamebbScriptID_Bool _uI_InteractivityBlocked;
		private gamebbScriptID_Bool _isInvestigated;

		[Ordinal(0)] 
		[RED("ActionWidgetsData")] 
		public gamebbScriptID_Variant ActionWidgetsData
		{
			get
			{
				if (_actionWidgetsData == null)
				{
					_actionWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ActionWidgetsData", cr2w, this);
				}
				return _actionWidgetsData;
			}
			set
			{
				if (_actionWidgetsData == value)
				{
					return;
				}
				_actionWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("DeviceWidgetsData")] 
		public gamebbScriptID_Variant DeviceWidgetsData
		{
			get
			{
				if (_deviceWidgetsData == null)
				{
					_deviceWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DeviceWidgetsData", cr2w, this);
				}
				return _deviceWidgetsData;
			}
			set
			{
				if (_deviceWidgetsData == value)
				{
					return;
				}
				_deviceWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("UIupdate")] 
		public gamebbScriptID_Bool UIupdate
		{
			get
			{
				if (_uIupdate == null)
				{
					_uIupdate = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UIupdate", cr2w, this);
				}
				return _uIupdate;
			}
			set
			{
				if (_uIupdate == value)
				{
					return;
				}
				_uIupdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("BreadCrumbElement")] 
		public gamebbScriptID_Variant BreadCrumbElement
		{
			get
			{
				if (_breadCrumbElement == null)
				{
					_breadCrumbElement = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BreadCrumbElement", cr2w, this);
				}
				return _breadCrumbElement;
			}
			set
			{
				if (_breadCrumbElement == value)
				{
					return;
				}
				_breadCrumbElement = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("GlitchData")] 
		public gamebbScriptID_Variant GlitchData
		{
			get
			{
				if (_glitchData == null)
				{
					_glitchData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "GlitchData", cr2w, this);
				}
				return _glitchData;
			}
			set
			{
				if (_glitchData == value)
				{
					return;
				}
				_glitchData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("UI_InteractivityBlocked")] 
		public gamebbScriptID_Bool UI_InteractivityBlocked
		{
			get
			{
				if (_uI_InteractivityBlocked == null)
				{
					_uI_InteractivityBlocked = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "UI_InteractivityBlocked", cr2w, this);
				}
				return _uI_InteractivityBlocked;
			}
			set
			{
				if (_uI_InteractivityBlocked == value)
				{
					return;
				}
				_uI_InteractivityBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("IsInvestigated")] 
		public gamebbScriptID_Bool IsInvestigated
		{
			get
			{
				if (_isInvestigated == null)
				{
					_isInvestigated = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInvestigated", cr2w, this);
				}
				return _isInvestigated;
			}
			set
			{
				if (_isInvestigated == value)
				{
					return;
				}
				_isInvestigated = value;
				PropertySet(this);
			}
		}

		public DeviceBaseBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
