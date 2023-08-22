using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleUIButtons : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("Button")] 
		public inkWidgetReference Button
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("Toggle1")] 
		public inkWidgetReference Toggle1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("Toggle2")] 
		public inkWidgetReference Toggle2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("Toggle3")] 
		public inkWidgetReference Toggle3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("RadioGroup")] 
		public inkWidgetReference RadioGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("Text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public SampleUIButtons()
		{
			Button = new inkWidgetReference();
			Toggle1 = new inkWidgetReference();
			Toggle2 = new inkWidgetReference();
			Toggle3 = new inkWidgetReference();
			RadioGroup = new inkWidgetReference();
			Text = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
