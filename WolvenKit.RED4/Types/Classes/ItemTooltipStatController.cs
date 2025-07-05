using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("statComparedContainer")] 
		public inkWidgetReference StatComparedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statComparedValue")] 
		public inkTextWidgetReference StatComparedValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("measurementUnit")] 
		public CEnum<EMeasurementUnit> MeasurementUnit
		{
			get => GetPropertyValue<CEnum<EMeasurementUnit>>();
			set => SetPropertyValue<CEnum<EMeasurementUnit>>(value);
		}

		[Ordinal(7)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(8)] 
		[RED("settingsListener")] 
		public CHandle<ItemTooltipStatSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<ItemTooltipStatSettingsListener>>();
			set => SetPropertyValue<CHandle<ItemTooltipStatSettingsListener>>(value);
		}

		[Ordinal(9)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("inCrafting")] 
		public CBool InCrafting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemTooltipStatController()
		{
			StatName = new inkTextWidgetReference();
			StatValue = new inkTextWidgetReference();
			StatComparedContainer = new inkWidgetReference();
			StatComparedValue = new inkTextWidgetReference();
			Arrow = new inkImageWidgetReference();
			GroupPath = "/accessibility/interface";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
