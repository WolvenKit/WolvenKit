using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceButtonLogicControllerBase : inkButtonController
	{
		private inkWidgetReference _targetWidgetRef;
		private inkTextWidgetReference _displayNameWidget;
		private inkImageWidgetReference _iconWidget;
		private inkImageWidgetReference _toggleSwitchWidget;
		private inkWidgetReference _sizeProviderWidget;
		private inkWidgetReference _selectionMarkerWidget;
		private CHandle<WidgetAnimationManager> _onReleaseAnimations;
		private CHandle<WidgetAnimationManager> _onPressAnimations;
		private CHandle<WidgetAnimationManager> _onHoverOverAnimations;
		private CHandle<WidgetAnimationManager> _onHoverOutAnimations;
		private redResourceReferenceScriptToken _defaultStyle;
		private redResourceReferenceScriptToken _selectionStyle;
		private SSoundData _soundData;
		private CBool _isInitialized;
		private wCHandle<inkWidget> _targetWidget;
		private CBool _isSelected;

		[Ordinal(10)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get
			{
				if (_targetWidgetRef == null)
				{
					_targetWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetWidgetRef", cr2w, this);
				}
				return _targetWidgetRef;
			}
			set
			{
				if (_targetWidgetRef == value)
				{
					return;
				}
				_targetWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get
			{
				if (_displayNameWidget == null)
				{
					_displayNameWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "displayNameWidget", cr2w, this);
				}
				return _displayNameWidget;
			}
			set
			{
				if (_displayNameWidget == value)
				{
					return;
				}
				_displayNameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("toggleSwitchWidget")] 
		public inkImageWidgetReference ToggleSwitchWidget
		{
			get
			{
				if (_toggleSwitchWidget == null)
				{
					_toggleSwitchWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "toggleSwitchWidget", cr2w, this);
				}
				return _toggleSwitchWidget;
			}
			set
			{
				if (_toggleSwitchWidget == value)
				{
					return;
				}
				_toggleSwitchWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("sizeProviderWidget")] 
		public inkWidgetReference SizeProviderWidget
		{
			get
			{
				if (_sizeProviderWidget == null)
				{
					_sizeProviderWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sizeProviderWidget", cr2w, this);
				}
				return _sizeProviderWidget;
			}
			set
			{
				if (_sizeProviderWidget == value)
				{
					return;
				}
				_sizeProviderWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("selectionMarkerWidget")] 
		public inkWidgetReference SelectionMarkerWidget
		{
			get
			{
				if (_selectionMarkerWidget == null)
				{
					_selectionMarkerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectionMarkerWidget", cr2w, this);
				}
				return _selectionMarkerWidget;
			}
			set
			{
				if (_selectionMarkerWidget == value)
				{
					return;
				}
				_selectionMarkerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("onReleaseAnimations")] 
		public CHandle<WidgetAnimationManager> OnReleaseAnimations
		{
			get
			{
				if (_onReleaseAnimations == null)
				{
					_onReleaseAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "onReleaseAnimations", cr2w, this);
				}
				return _onReleaseAnimations;
			}
			set
			{
				if (_onReleaseAnimations == value)
				{
					return;
				}
				_onReleaseAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("onPressAnimations")] 
		public CHandle<WidgetAnimationManager> OnPressAnimations
		{
			get
			{
				if (_onPressAnimations == null)
				{
					_onPressAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "onPressAnimations", cr2w, this);
				}
				return _onPressAnimations;
			}
			set
			{
				if (_onPressAnimations == value)
				{
					return;
				}
				_onPressAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("onHoverOverAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOverAnimations
		{
			get
			{
				if (_onHoverOverAnimations == null)
				{
					_onHoverOverAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "onHoverOverAnimations", cr2w, this);
				}
				return _onHoverOverAnimations;
			}
			set
			{
				if (_onHoverOverAnimations == value)
				{
					return;
				}
				_onHoverOverAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("onHoverOutAnimations")] 
		public CHandle<WidgetAnimationManager> OnHoverOutAnimations
		{
			get
			{
				if (_onHoverOutAnimations == null)
				{
					_onHoverOutAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "onHoverOutAnimations", cr2w, this);
				}
				return _onHoverOutAnimations;
			}
			set
			{
				if (_onHoverOutAnimations == value)
				{
					return;
				}
				_onHoverOutAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("defaultStyle")] 
		public redResourceReferenceScriptToken DefaultStyle
		{
			get
			{
				if (_defaultStyle == null)
				{
					_defaultStyle = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "defaultStyle", cr2w, this);
				}
				return _defaultStyle;
			}
			set
			{
				if (_defaultStyle == value)
				{
					return;
				}
				_defaultStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("selectionStyle")] 
		public redResourceReferenceScriptToken SelectionStyle
		{
			get
			{
				if (_selectionStyle == null)
				{
					_selectionStyle = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "selectionStyle", cr2w, this);
				}
				return _selectionStyle;
			}
			set
			{
				if (_selectionStyle == value)
				{
					return;
				}
				_selectionStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get
			{
				if (_soundData == null)
				{
					_soundData = (SSoundData) CR2WTypeManager.Create("SSoundData", "soundData", cr2w, this);
				}
				return _soundData;
			}
			set
			{
				if (_soundData == value)
				{
					return;
				}
				_soundData = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("targetWidget")] 
		public wCHandle<inkWidget> TargetWidget
		{
			get
			{
				if (_targetWidget == null)
				{
					_targetWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "targetWidget", cr2w, this);
				}
				return _targetWidget;
			}
			set
			{
				if (_targetWidget == value)
				{
					return;
				}
				_targetWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get
			{
				if (_isSelected == null)
				{
					_isSelected = (CBool) CR2WTypeManager.Create("Bool", "isSelected", cr2w, this);
				}
				return _isSelected;
			}
			set
			{
				if (_isSelected == value)
				{
					return;
				}
				_isSelected = value;
				PropertySet(this);
			}
		}

		public DeviceButtonLogicControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
