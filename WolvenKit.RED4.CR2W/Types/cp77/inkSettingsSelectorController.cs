using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorController : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _modifiedFlag;
		private inkWidgetReference _raycaster;
		private inkWidgetReference _optionSwitchHint;
		private inkWidgetReference _hoverGeneralHighlight;
		private inkWidgetReference _container;
		private wCHandle<userSettingsVar> _settingsEntry;
		private CArray<wCHandle<inkWidget>> _hoveredChildren;
		private CBool _isPreGame;
		private CName _varGroupPath;
		private CName _varName;
		private CName _additionalText;
		private CHandle<inkanimProxy> _hoverInAnim;
		private CHandle<inkanimProxy> _hoverOutAnim;

		[Ordinal(1)] 
		[RED("LabelText")] 
		public inkTextWidgetReference LabelText
		{
			get
			{
				if (_labelText == null)
				{
					_labelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "LabelText", cr2w, this);
				}
				return _labelText;
			}
			set
			{
				if (_labelText == value)
				{
					return;
				}
				_labelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ModifiedFlag")] 
		public inkTextWidgetReference ModifiedFlag
		{
			get
			{
				if (_modifiedFlag == null)
				{
					_modifiedFlag = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ModifiedFlag", cr2w, this);
				}
				return _modifiedFlag;
			}
			set
			{
				if (_modifiedFlag == value)
				{
					return;
				}
				_modifiedFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Raycaster")] 
		public inkWidgetReference Raycaster
		{
			get
			{
				if (_raycaster == null)
				{
					_raycaster = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Raycaster", cr2w, this);
				}
				return _raycaster;
			}
			set
			{
				if (_raycaster == value)
				{
					return;
				}
				_raycaster = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get
			{
				if (_optionSwitchHint == null)
				{
					_optionSwitchHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "optionSwitchHint", cr2w, this);
				}
				return _optionSwitchHint;
			}
			set
			{
				if (_optionSwitchHint == value)
				{
					return;
				}
				_optionSwitchHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hoverGeneralHighlight")] 
		public inkWidgetReference HoverGeneralHighlight
		{
			get
			{
				if (_hoverGeneralHighlight == null)
				{
					_hoverGeneralHighlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hoverGeneralHighlight", cr2w, this);
				}
				return _hoverGeneralHighlight;
			}
			set
			{
				if (_hoverGeneralHighlight == value)
				{
					return;
				}
				_hoverGeneralHighlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("SettingsEntry")] 
		public wCHandle<userSettingsVar> SettingsEntry
		{
			get
			{
				if (_settingsEntry == null)
				{
					_settingsEntry = (wCHandle<userSettingsVar>) CR2WTypeManager.Create("whandle:userSettingsVar", "SettingsEntry", cr2w, this);
				}
				return _settingsEntry;
			}
			set
			{
				if (_settingsEntry == value)
				{
					return;
				}
				_settingsEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hoveredChildren")] 
		public CArray<wCHandle<inkWidget>> HoveredChildren
		{
			get
			{
				if (_hoveredChildren == null)
				{
					_hoveredChildren = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "hoveredChildren", cr2w, this);
				}
				return _hoveredChildren;
			}
			set
			{
				if (_hoveredChildren == value)
				{
					return;
				}
				_hoveredChildren = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("IsPreGame")] 
		public CBool IsPreGame
		{
			get
			{
				if (_isPreGame == null)
				{
					_isPreGame = (CBool) CR2WTypeManager.Create("Bool", "IsPreGame", cr2w, this);
				}
				return _isPreGame;
			}
			set
			{
				if (_isPreGame == value)
				{
					return;
				}
				_isPreGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("varGroupPath")] 
		public CName VarGroupPath
		{
			get
			{
				if (_varGroupPath == null)
				{
					_varGroupPath = (CName) CR2WTypeManager.Create("CName", "varGroupPath", cr2w, this);
				}
				return _varGroupPath;
			}
			set
			{
				if (_varGroupPath == value)
				{
					return;
				}
				_varGroupPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("varName")] 
		public CName VarName
		{
			get
			{
				if (_varName == null)
				{
					_varName = (CName) CR2WTypeManager.Create("CName", "varName", cr2w, this);
				}
				return _varName;
			}
			set
			{
				if (_varName == value)
				{
					return;
				}
				_varName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("additionalText")] 
		public CName AdditionalText
		{
			get
			{
				if (_additionalText == null)
				{
					_additionalText = (CName) CR2WTypeManager.Create("CName", "additionalText", cr2w, this);
				}
				return _additionalText;
			}
			set
			{
				if (_additionalText == value)
				{
					return;
				}
				_additionalText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hoverInAnim")] 
		public CHandle<inkanimProxy> HoverInAnim
		{
			get
			{
				if (_hoverInAnim == null)
				{
					_hoverInAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hoverInAnim", cr2w, this);
				}
				return _hoverInAnim;
			}
			set
			{
				if (_hoverInAnim == value)
				{
					return;
				}
				_hoverInAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hoverOutAnim")] 
		public CHandle<inkanimProxy> HoverOutAnim
		{
			get
			{
				if (_hoverOutAnim == null)
				{
					_hoverOutAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hoverOutAnim", cr2w, this);
				}
				return _hoverOutAnim;
			}
			set
			{
				if (_hoverOutAnim == value)
				{
					return;
				}
				_hoverOutAnim = value;
				PropertySet(this);
			}
		}

		public inkSettingsSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
