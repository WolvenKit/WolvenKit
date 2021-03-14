using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationInfo : IScriptable
	{
		private CName _name;
		private CName _uiSlot;
		private CString _localizedName;
		private CInt32 _defaultIndex;
		private CInt32 _index;
		private CBool _hidden;
		private CBool _enabled;
		private CName _link;
		private CBool _linkController;
		private CEnum<CensorshipFlags> _censorFlag;
		private CEnum<gameuiCharacterCustomizationActionType> _censorFlagAction;
		private CArray<gameuiCharacterCustomizationAction> _onDeactivateActions;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("uiSlot")] 
		public CName UiSlot
		{
			get
			{
				if (_uiSlot == null)
				{
					_uiSlot = (CName) CR2WTypeManager.Create("CName", "uiSlot", cr2w, this);
				}
				return _uiSlot;
			}
			set
			{
				if (_uiSlot == value)
				{
					return;
				}
				_uiSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultIndex")] 
		public CInt32 DefaultIndex
		{
			get
			{
				if (_defaultIndex == null)
				{
					_defaultIndex = (CInt32) CR2WTypeManager.Create("Int32", "defaultIndex", cr2w, this);
				}
				return _defaultIndex;
			}
			set
			{
				if (_defaultIndex == value)
				{
					return;
				}
				_defaultIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hidden")] 
		public CBool Hidden
		{
			get
			{
				if (_hidden == null)
				{
					_hidden = (CBool) CR2WTypeManager.Create("Bool", "hidden", cr2w, this);
				}
				return _hidden;
			}
			set
			{
				if (_hidden == value)
				{
					return;
				}
				_hidden = value;
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

		[Ordinal(7)] 
		[RED("link")] 
		public CName Link
		{
			get
			{
				if (_link == null)
				{
					_link = (CName) CR2WTypeManager.Create("CName", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("linkController")] 
		public CBool LinkController
		{
			get
			{
				if (_linkController == null)
				{
					_linkController = (CBool) CR2WTypeManager.Create("Bool", "linkController", cr2w, this);
				}
				return _linkController;
			}
			set
			{
				if (_linkController == value)
				{
					return;
				}
				_linkController = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("censorFlag")] 
		public CEnum<CensorshipFlags> CensorFlag
		{
			get
			{
				if (_censorFlag == null)
				{
					_censorFlag = (CEnum<CensorshipFlags>) CR2WTypeManager.Create("CensorshipFlags", "censorFlag", cr2w, this);
				}
				return _censorFlag;
			}
			set
			{
				if (_censorFlag == value)
				{
					return;
				}
				_censorFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get
			{
				if (_censorFlagAction == null)
				{
					_censorFlagAction = (CEnum<gameuiCharacterCustomizationActionType>) CR2WTypeManager.Create("gameuiCharacterCustomizationActionType", "censorFlagAction", cr2w, this);
				}
				return _censorFlagAction;
			}
			set
			{
				if (_censorFlagAction == value)
				{
					return;
				}
				_censorFlagAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("onDeactivateActions")] 
		public CArray<gameuiCharacterCustomizationAction> OnDeactivateActions
		{
			get
			{
				if (_onDeactivateActions == null)
				{
					_onDeactivateActions = (CArray<gameuiCharacterCustomizationAction>) CR2WTypeManager.Create("array:gameuiCharacterCustomizationAction", "onDeactivateActions", cr2w, this);
				}
				return _onDeactivateActions;
			}
			set
			{
				if (_onDeactivateActions == value)
				{
					return;
				}
				_onDeactivateActions = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
