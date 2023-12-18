using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerBool : inkSettingsSelectorController
	{
		[Ordinal(16)] 
		[RED("onState")] 
		public inkWidgetReference OnState
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("offState")] 
		public inkWidgetReference OffState
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("onStateBody")] 
		public inkWidgetReference OnStateBody
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("offStateBody")] 
		public inkWidgetReference OffStateBody
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SettingsSelectorControllerBool()
		{
			OnState = new inkWidgetReference();
			OffState = new inkWidgetReference();
			OnStateBody = new inkWidgetReference();
			OffStateBody = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
