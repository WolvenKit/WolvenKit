using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextReplaceAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("widgetTextUsage")] 
		public CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> WidgetTextUsage
		{
			get => GetPropertyValue<CEnum<inkTextReplaceAnimationControllerWidgetTextUsage>>();
			set => SetPropertyValue<CEnum<inkTextReplaceAnimationControllerWidgetTextUsage>>(value);
		}

		[Ordinal(10)] 
		[RED("baseTextLocalized")] 
		public LocalizationString BaseTextLocalized
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(11)] 
		[RED("targetText")] 
		public CString TargetText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("targetTextLocalized")] 
		public LocalizationString TargetTextLocalized
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public inkTextReplaceAnimationController()
		{
			PlayOnInitialize = true;
			UseDefaultAnimation = true;
			EndValue = 1.000000F;
			TimeToSkip = 0.050000F;
			BaseTextLocalized = new() { Unk1 = 0, Value = "" };
			TargetTextLocalized = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
