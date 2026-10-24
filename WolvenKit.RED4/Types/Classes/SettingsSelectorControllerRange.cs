using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerRange : inkSettingsSelectorController
	{
		[Ordinal(17)] 
		[RED("ValueText")] 
		public inkTextWidgetReference ValueText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("ProgressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SettingsSelectorControllerRange()
		{
			ValueText = new inkTextWidgetReference();
			LeftArrow = new inkWidgetReference();
			RightArrow = new inkWidgetReference();
			ProgressBar = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
