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
			get => GetProperty(ref _backgroundContainer);
			set => SetProperty(ref _backgroundContainer, value);
		}

		[Ordinal(3)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(4)] 
		[RED("tierText")] 
		public inkTextWidgetReference TierText
		{
			get => GetProperty(ref _tierText);
			set => SetProperty(ref _tierText, value);
		}

		[Ordinal(5)] 
		[RED("durationWidget")] 
		public inkWidgetReference DurationWidget
		{
			get => GetProperty(ref _durationWidget);
			set => SetProperty(ref _durationWidget, value);
		}

		[Ordinal(6)] 
		[RED("uploadTimeWidget")] 
		public inkWidgetReference UploadTimeWidget
		{
			get => GetProperty(ref _uploadTimeWidget);
			set => SetProperty(ref _uploadTimeWidget, value);
		}

		[Ordinal(7)] 
		[RED("cooldownWidget")] 
		public inkWidgetReference CooldownWidget
		{
			get => GetProperty(ref _cooldownWidget);
			set => SetProperty(ref _cooldownWidget, value);
		}

		[Ordinal(8)] 
		[RED("memoryCostValueText")] 
		public inkTextWidgetReference MemoryCostValueText
		{
			get => GetProperty(ref _memoryCostValueText);
			set => SetProperty(ref _memoryCostValueText, value);
		}

		[Ordinal(9)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get => GetProperty(ref _damageWrapper);
			set => SetProperty(ref _damageWrapper, value);
		}

		[Ordinal(10)] 
		[RED("damageLabel")] 
		public inkTextWidgetReference DamageLabel
		{
			get => GetProperty(ref _damageLabel);
			set => SetProperty(ref _damageLabel, value);
		}

		[Ordinal(11)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get => GetProperty(ref _damageValue);
			set => SetProperty(ref _damageValue, value);
		}

		[Ordinal(12)] 
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get => GetProperty(ref _healthPercentageLabel);
			set => SetProperty(ref _healthPercentageLabel, value);
		}

		[Ordinal(13)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(14)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(15)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(16)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(17)] 
		[RED("hackTypeWrapper")] 
		public inkWidgetReference HackTypeWrapper
		{
			get => GetProperty(ref _hackTypeWrapper);
			set => SetProperty(ref _hackTypeWrapper, value);
		}

		[Ordinal(18)] 
		[RED("hackTypeText")] 
		public inkTextWidgetReference HackTypeText
		{
			get => GetProperty(ref _hackTypeText);
			set => SetProperty(ref _hackTypeText, value);
		}

		[Ordinal(19)] 
		[RED("effectsList")] 
		public inkCompoundWidgetReference EffectsList
		{
			get => GetProperty(ref _effectsList);
			set => SetProperty(ref _effectsList, value);
		}

		[Ordinal(20)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(21)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(22)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetProperty(ref _dEBUG_showAdditionalInfo);
			set => SetProperty(ref _dEBUG_showAdditionalInfo, value);
		}

		[Ordinal(23)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(24)] 
		[RED("quickHackData")] 
		public InventoryTooltipData_QuickhackData QuickHackData
		{
			get => GetProperty(ref _quickHackData);
			set => SetProperty(ref _quickHackData, value);
		}

		public ProgramTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
