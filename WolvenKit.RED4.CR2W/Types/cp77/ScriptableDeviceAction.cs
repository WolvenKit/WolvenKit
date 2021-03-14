using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceAction : BaseScriptableAction
	{
		private CHandle<gamedeviceActionProperty> _prop;
		private SActionWidgetPackage _actionWidgetPackage;
		private NodeRef _spiderbotActionLocationOverride;
		private CFloat _duration;
		private CBool _canTriggerStim;
		private CBool _wasPerformedOnOwner;
		private CBool _shouldActivateDevice;
		private CBool _isQuickHack;
		private CBool _isSpiderbotAction;
		private TweakDBID _attachedProgram;
		private TweakDBID _activeStatusEffect;
		private TweakDBID _interactionIconType;
		private CBool _hasInteraction;
		private CString _inactiveReason;

		[Ordinal(11)] 
		[RED("prop")] 
		public CHandle<gamedeviceActionProperty> Prop
		{
			get
			{
				if (_prop == null)
				{
					_prop = (CHandle<gamedeviceActionProperty>) CR2WTypeManager.Create("handle:gamedeviceActionProperty", "prop", cr2w, this);
				}
				return _prop;
			}
			set
			{
				if (_prop == value)
				{
					return;
				}
				_prop = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("actionWidgetPackage")] 
		public SActionWidgetPackage ActionWidgetPackage
		{
			get
			{
				if (_actionWidgetPackage == null)
				{
					_actionWidgetPackage = (SActionWidgetPackage) CR2WTypeManager.Create("SActionWidgetPackage", "actionWidgetPackage", cr2w, this);
				}
				return _actionWidgetPackage;
			}
			set
			{
				if (_actionWidgetPackage == value)
				{
					return;
				}
				_actionWidgetPackage = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("spiderbotActionLocationOverride")] 
		public NodeRef SpiderbotActionLocationOverride
		{
			get
			{
				if (_spiderbotActionLocationOverride == null)
				{
					_spiderbotActionLocationOverride = (NodeRef) CR2WTypeManager.Create("NodeRef", "spiderbotActionLocationOverride", cr2w, this);
				}
				return _spiderbotActionLocationOverride;
			}
			set
			{
				if (_spiderbotActionLocationOverride == value)
				{
					return;
				}
				_spiderbotActionLocationOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("canTriggerStim")] 
		public CBool CanTriggerStim
		{
			get
			{
				if (_canTriggerStim == null)
				{
					_canTriggerStim = (CBool) CR2WTypeManager.Create("Bool", "canTriggerStim", cr2w, this);
				}
				return _canTriggerStim;
			}
			set
			{
				if (_canTriggerStim == value)
				{
					return;
				}
				_canTriggerStim = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("wasPerformedOnOwner")] 
		public CBool WasPerformedOnOwner
		{
			get
			{
				if (_wasPerformedOnOwner == null)
				{
					_wasPerformedOnOwner = (CBool) CR2WTypeManager.Create("Bool", "wasPerformedOnOwner", cr2w, this);
				}
				return _wasPerformedOnOwner;
			}
			set
			{
				if (_wasPerformedOnOwner == value)
				{
					return;
				}
				_wasPerformedOnOwner = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("shouldActivateDevice")] 
		public CBool ShouldActivateDevice
		{
			get
			{
				if (_shouldActivateDevice == null)
				{
					_shouldActivateDevice = (CBool) CR2WTypeManager.Create("Bool", "shouldActivateDevice", cr2w, this);
				}
				return _shouldActivateDevice;
			}
			set
			{
				if (_shouldActivateDevice == value)
				{
					return;
				}
				_shouldActivateDevice = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get
			{
				if (_isQuickHack == null)
				{
					_isQuickHack = (CBool) CR2WTypeManager.Create("Bool", "isQuickHack", cr2w, this);
				}
				return _isQuickHack;
			}
			set
			{
				if (_isQuickHack == value)
				{
					return;
				}
				_isQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get
			{
				if (_isSpiderbotAction == null)
				{
					_isSpiderbotAction = (CBool) CR2WTypeManager.Create("Bool", "isSpiderbotAction", cr2w, this);
				}
				return _isSpiderbotAction;
			}
			set
			{
				if (_isSpiderbotAction == value)
				{
					return;
				}
				_isSpiderbotAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("attachedProgram")] 
		public TweakDBID AttachedProgram
		{
			get
			{
				if (_attachedProgram == null)
				{
					_attachedProgram = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attachedProgram", cr2w, this);
				}
				return _attachedProgram;
			}
			set
			{
				if (_attachedProgram == value)
				{
					return;
				}
				_attachedProgram = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get
			{
				if (_activeStatusEffect == null)
				{
					_activeStatusEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "activeStatusEffect", cr2w, this);
				}
				return _activeStatusEffect;
			}
			set
			{
				if (_activeStatusEffect == value)
				{
					return;
				}
				_activeStatusEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("interactionIconType")] 
		public TweakDBID InteractionIconType
		{
			get
			{
				if (_interactionIconType == null)
				{
					_interactionIconType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "interactionIconType", cr2w, this);
				}
				return _interactionIconType;
			}
			set
			{
				if (_interactionIconType == value)
				{
					return;
				}
				_interactionIconType = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get
			{
				if (_hasInteraction == null)
				{
					_hasInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasInteraction", cr2w, this);
				}
				return _hasInteraction;
			}
			set
			{
				if (_hasInteraction == value)
				{
					return;
				}
				_hasInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get
			{
				if (_inactiveReason == null)
				{
					_inactiveReason = (CString) CR2WTypeManager.Create("String", "inactiveReason", cr2w, this);
				}
				return _inactiveReason;
			}
			set
			{
				if (_inactiveReason == value)
				{
					return;
				}
				_inactiveReason = value;
				PropertySet(this);
			}
		}

		public ScriptableDeviceAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
