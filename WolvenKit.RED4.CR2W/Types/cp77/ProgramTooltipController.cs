using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipController : AGenericTooltipController
	{
		private inkCompoundWidgetReference _backgroundContainer;
		private inkTextWidgetReference _nameText;
		private inkTextWidgetReference _tierText;
		private inkWidgetReference _durationWidget;
		private inkWidgetReference _uploadTimeWidget;
		private inkWidgetReference _cooldownWidget;
		private inkTextWidgetReference _memoryCostValueText;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageLabel;
		private inkTextWidgetReference _damageValue;
		private inkTextWidgetReference _healthPercentageLabel;
		private inkWidgetReference _priceContainer;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _descriptionWrapper;
		private inkTextWidgetReference _descriptionText;
		private inkWidgetReference _hackTypeWrapper;
		private inkTextWidgetReference _hackTypeText;
		private inkCompoundWidgetReference _effectsList;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<InventoryTooltipData> _data;
		private InventoryTooltipData_QuickhackData _quickHackData;

		[Ordinal(2)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get
			{
				if (_backgroundContainer == null)
				{
					_backgroundContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "backgroundContainer", cr2w, this);
				}
				return _backgroundContainer;
			}
			set
			{
				if (_backgroundContainer == value)
				{
					return;
				}
				_backgroundContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get
			{
				if (_nameText == null)
				{
					_nameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameText", cr2w, this);
				}
				return _nameText;
			}
			set
			{
				if (_nameText == value)
				{
					return;
				}
				_nameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tierText")] 
		public inkTextWidgetReference TierText
		{
			get
			{
				if (_tierText == null)
				{
					_tierText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "tierText", cr2w, this);
				}
				return _tierText;
			}
			set
			{
				if (_tierText == value)
				{
					return;
				}
				_tierText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("durationWidget")] 
		public inkWidgetReference DurationWidget
		{
			get
			{
				if (_durationWidget == null)
				{
					_durationWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "durationWidget", cr2w, this);
				}
				return _durationWidget;
			}
			set
			{
				if (_durationWidget == value)
				{
					return;
				}
				_durationWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("uploadTimeWidget")] 
		public inkWidgetReference UploadTimeWidget
		{
			get
			{
				if (_uploadTimeWidget == null)
				{
					_uploadTimeWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "uploadTimeWidget", cr2w, this);
				}
				return _uploadTimeWidget;
			}
			set
			{
				if (_uploadTimeWidget == value)
				{
					return;
				}
				_uploadTimeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cooldownWidget")] 
		public inkWidgetReference CooldownWidget
		{
			get
			{
				if (_cooldownWidget == null)
				{
					_cooldownWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cooldownWidget", cr2w, this);
				}
				return _cooldownWidget;
			}
			set
			{
				if (_cooldownWidget == value)
				{
					return;
				}
				_cooldownWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("memoryCostValueText")] 
		public inkTextWidgetReference MemoryCostValueText
		{
			get
			{
				if (_memoryCostValueText == null)
				{
					_memoryCostValueText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryCostValueText", cr2w, this);
				}
				return _memoryCostValueText;
			}
			set
			{
				if (_memoryCostValueText == value)
				{
					return;
				}
				_memoryCostValueText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get
			{
				if (_damageWrapper == null)
				{
					_damageWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageWrapper", cr2w, this);
				}
				return _damageWrapper;
			}
			set
			{
				if (_damageWrapper == value)
				{
					return;
				}
				_damageWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("damageLabel")] 
		public inkTextWidgetReference DamageLabel
		{
			get
			{
				if (_damageLabel == null)
				{
					_damageLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damageLabel", cr2w, this);
				}
				return _damageLabel;
			}
			set
			{
				if (_damageLabel == value)
				{
					return;
				}
				_damageLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get
			{
				if (_damageValue == null)
				{
					_damageValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damageValue", cr2w, this);
				}
				return _damageValue;
			}
			set
			{
				if (_damageValue == value)
				{
					return;
				}
				_damageValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get
			{
				if (_healthPercentageLabel == null)
				{
					_healthPercentageLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthPercentageLabel", cr2w, this);
				}
				return _healthPercentageLabel;
			}
			set
			{
				if (_healthPercentageLabel == value)
				{
					return;
				}
				_healthPercentageLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get
			{
				if (_priceContainer == null)
				{
					_priceContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priceContainer", cr2w, this);
				}
				return _priceContainer;
			}
			set
			{
				if (_priceContainer == value)
				{
					return;
				}
				_priceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get
			{
				if (_descriptionWrapper == null)
				{
					_descriptionWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionWrapper", cr2w, this);
				}
				return _descriptionWrapper;
			}
			set
			{
				if (_descriptionWrapper == value)
				{
					return;
				}
				_descriptionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hackTypeWrapper")] 
		public inkWidgetReference HackTypeWrapper
		{
			get
			{
				if (_hackTypeWrapper == null)
				{
					_hackTypeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "hackTypeWrapper", cr2w, this);
				}
				return _hackTypeWrapper;
			}
			set
			{
				if (_hackTypeWrapper == value)
				{
					return;
				}
				_hackTypeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("hackTypeText")] 
		public inkTextWidgetReference HackTypeText
		{
			get
			{
				if (_hackTypeText == null)
				{
					_hackTypeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "hackTypeText", cr2w, this);
				}
				return _hackTypeText;
			}
			set
			{
				if (_hackTypeText == value)
				{
					return;
				}
				_hackTypeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("effectsList")] 
		public inkCompoundWidgetReference EffectsList
		{
			get
			{
				if (_effectsList == null)
				{
					_effectsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "effectsList", cr2w, this);
				}
				return _effectsList;
			}
			set
			{
				if (_effectsList == value)
				{
					return;
				}
				_effectsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get
			{
				if (_dEBUG_iconErrorWrapper == null)
				{
					_dEBUG_iconErrorWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "DEBUG_iconErrorWrapper", cr2w, this);
				}
				return _dEBUG_iconErrorWrapper;
			}
			set
			{
				if (_dEBUG_iconErrorWrapper == value)
				{
					return;
				}
				_dEBUG_iconErrorWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get
			{
				if (_dEBUG_iconErrorText == null)
				{
					_dEBUG_iconErrorText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DEBUG_iconErrorText", cr2w, this);
				}
				return _dEBUG_iconErrorText;
			}
			set
			{
				if (_dEBUG_iconErrorText == value)
				{
					return;
				}
				_dEBUG_iconErrorText = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get
			{
				if (_dEBUG_showAdditionalInfo == null)
				{
					_dEBUG_showAdditionalInfo = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_showAdditionalInfo", cr2w, this);
				}
				return _dEBUG_showAdditionalInfo;
			}
			set
			{
				if (_dEBUG_showAdditionalInfo == value)
				{
					return;
				}
				_dEBUG_showAdditionalInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("quickHackData")] 
		public InventoryTooltipData_QuickhackData QuickHackData
		{
			get
			{
				if (_quickHackData == null)
				{
					_quickHackData = (InventoryTooltipData_QuickhackData) CR2WTypeManager.Create("InventoryTooltipData_QuickhackData", "quickHackData", cr2w, this);
				}
				return _quickHackData;
			}
			set
			{
				if (_quickHackData == value)
				{
					return;
				}
				_quickHackData = value;
				PropertySet(this);
			}
		}

		public ProgramTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
