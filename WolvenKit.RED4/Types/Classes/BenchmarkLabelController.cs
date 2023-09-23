using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BenchmarkLabelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("labelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("valueWidget")] 
		public inkTextWidgetReference ValueWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public BenchmarkLabelController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
