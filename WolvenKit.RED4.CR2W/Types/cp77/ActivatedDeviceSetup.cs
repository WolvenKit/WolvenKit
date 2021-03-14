using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceSetup : CVariable
	{
		private CName _actionName;
		private CBool _disableOnActivation;
		private CBool _glitchOnActivation;
		private gameFxResource _vfxResource;
		private CName _activationVFXname;
		private CBool _hasSimpleInteraction;
		private CBool _hasSpiderbotInteraction;
		private CBool _hasQuickHack;
		private CBool _hasQuickHackDistraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<EngDemoContainer> _activatedDeviceSkillChecks;
		private TweakDBID _attackType;
		private CBool _shouldActivateTrapOnAreaEnter;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailIconRecord;
		private TweakDBID _actionWidgetRecord;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get
			{
				if (_actionName == null)
				{
					_actionName = (CName) CR2WTypeManager.Create("CName", "actionName", cr2w, this);
				}
				return _actionName;
			}
			set
			{
				if (_actionName == value)
				{
					return;
				}
				_actionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("disableOnActivation")] 
		public CBool DisableOnActivation
		{
			get
			{
				if (_disableOnActivation == null)
				{
					_disableOnActivation = (CBool) CR2WTypeManager.Create("Bool", "disableOnActivation", cr2w, this);
				}
				return _disableOnActivation;
			}
			set
			{
				if (_disableOnActivation == value)
				{
					return;
				}
				_disableOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("glitchOnActivation")] 
		public CBool GlitchOnActivation
		{
			get
			{
				if (_glitchOnActivation == null)
				{
					_glitchOnActivation = (CBool) CR2WTypeManager.Create("Bool", "glitchOnActivation", cr2w, this);
				}
				return _glitchOnActivation;
			}
			set
			{
				if (_glitchOnActivation == value)
				{
					return;
				}
				_glitchOnActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get
			{
				if (_vfxResource == null)
				{
					_vfxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "vfxResource", cr2w, this);
				}
				return _vfxResource;
			}
			set
			{
				if (_vfxResource == value)
				{
					return;
				}
				_vfxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activationVFXname")] 
		public CName ActivationVFXname
		{
			get
			{
				if (_activationVFXname == null)
				{
					_activationVFXname = (CName) CR2WTypeManager.Create("CName", "activationVFXname", cr2w, this);
				}
				return _activationVFXname;
			}
			set
			{
				if (_activationVFXname == value)
				{
					return;
				}
				_activationVFXname = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get
			{
				if (_hasSimpleInteraction == null)
				{
					_hasSimpleInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasSimpleInteraction", cr2w, this);
				}
				return _hasSimpleInteraction;
			}
			set
			{
				if (_hasSimpleInteraction == value)
				{
					return;
				}
				_hasSimpleInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get
			{
				if (_hasSpiderbotInteraction == null)
				{
					_hasSpiderbotInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasSpiderbotInteraction", cr2w, this);
				}
				return _hasSpiderbotInteraction;
			}
			set
			{
				if (_hasSpiderbotInteraction == value)
				{
					return;
				}
				_hasSpiderbotInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get
			{
				if (_hasQuickHack == null)
				{
					_hasQuickHack = (CBool) CR2WTypeManager.Create("Bool", "hasQuickHack", cr2w, this);
				}
				return _hasQuickHack;
			}
			set
			{
				if (_hasQuickHack == value)
				{
					return;
				}
				_hasQuickHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hasQuickHackDistraction")] 
		public CBool HasQuickHackDistraction
		{
			get
			{
				if (_hasQuickHackDistraction == null)
				{
					_hasQuickHackDistraction = (CBool) CR2WTypeManager.Create("Bool", "hasQuickHackDistraction", cr2w, this);
				}
				return _hasQuickHackDistraction;
			}
			set
			{
				if (_hasQuickHackDistraction == value)
				{
					return;
				}
				_hasQuickHackDistraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get
			{
				if (_alternativeInteractionName == null)
				{
					_alternativeInteractionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeInteractionName", cr2w, this);
				}
				return _alternativeInteractionName;
			}
			set
			{
				if (_alternativeInteractionName == value)
				{
					return;
				}
				_alternativeInteractionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get
			{
				if (_alternativeSpiderbotInteractionName == null)
				{
					_alternativeSpiderbotInteractionName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeSpiderbotInteractionName", cr2w, this);
				}
				return _alternativeSpiderbotInteractionName;
			}
			set
			{
				if (_alternativeSpiderbotInteractionName == value)
				{
					return;
				}
				_alternativeSpiderbotInteractionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get
			{
				if (_alternativeQuickHackName == null)
				{
					_alternativeQuickHackName = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "alternativeQuickHackName", cr2w, this);
				}
				return _alternativeQuickHackName;
			}
			set
			{
				if (_alternativeQuickHackName == value)
				{
					return;
				}
				_alternativeQuickHackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("activatedDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> ActivatedDeviceSkillChecks
		{
			get
			{
				if (_activatedDeviceSkillChecks == null)
				{
					_activatedDeviceSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "activatedDeviceSkillChecks", cr2w, this);
				}
				return _activatedDeviceSkillChecks;
			}
			set
			{
				if (_activatedDeviceSkillChecks == value)
				{
					return;
				}
				_activatedDeviceSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("shouldActivateTrapOnAreaEnter")] 
		public CBool ShouldActivateTrapOnAreaEnter
		{
			get
			{
				if (_shouldActivateTrapOnAreaEnter == null)
				{
					_shouldActivateTrapOnAreaEnter = (CBool) CR2WTypeManager.Create("Bool", "shouldActivateTrapOnAreaEnter", cr2w, this);
				}
				return _shouldActivateTrapOnAreaEnter;
			}
			set
			{
				if (_shouldActivateTrapOnAreaEnter == value)
				{
					return;
				}
				_shouldActivateTrapOnAreaEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get
			{
				if (_deviceWidgetRecord == null)
				{
					_deviceWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "deviceWidgetRecord", cr2w, this);
				}
				return _deviceWidgetRecord;
			}
			set
			{
				if (_deviceWidgetRecord == value)
				{
					return;
				}
				_deviceWidgetRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("thumbnailIconRecord")] 
		public TweakDBID ThumbnailIconRecord
		{
			get
			{
				if (_thumbnailIconRecord == null)
				{
					_thumbnailIconRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "thumbnailIconRecord", cr2w, this);
				}
				return _thumbnailIconRecord;
			}
			set
			{
				if (_thumbnailIconRecord == value)
				{
					return;
				}
				_thumbnailIconRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get
			{
				if (_actionWidgetRecord == null)
				{
					_actionWidgetRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionWidgetRecord", cr2w, this);
				}
				return _actionWidgetRecord;
			}
			set
			{
				if (_actionWidgetRecord == value)
				{
					return;
				}
				_actionWidgetRecord = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
