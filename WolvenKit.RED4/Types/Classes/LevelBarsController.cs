using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LevelBarsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bar0")] 
		public inkWidgetReference Bar0
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bar1")] 
		public inkWidgetReference Bar1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("bar2")] 
		public inkWidgetReference Bar2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("bar3")] 
		public inkWidgetReference Bar3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("bar4")] 
		public inkWidgetReference Bar4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("bars", 5)] 
		public CArrayFixedSize<inkWidgetReference> Bars
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		public LevelBarsController()
		{
			Bar0 = new inkWidgetReference();
			Bar1 = new inkWidgetReference();
			Bar2 = new inkWidgetReference();
			Bar3 = new inkWidgetReference();
			Bar4 = new inkWidgetReference();
			Bars = new(5);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
