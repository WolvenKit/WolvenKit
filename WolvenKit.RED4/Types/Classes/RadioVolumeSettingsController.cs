using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioVolumeSettingsController : inkSettingsSelectorController
	{
		[Ordinal(16)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public RadioVolumeSettingsController()
		{
			Value = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
