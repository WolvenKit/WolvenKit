using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FUNC_TEST_Container : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("BasePanel")] 
		public inkBasePanelWidgetReference BasePanel
		{
			get => GetPropertyValue<inkBasePanelWidgetReference>();
			set => SetPropertyValue<inkBasePanelWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("Compound")] 
		public inkCompoundWidgetReference Compound
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("Leaf")] 
		public inkLeafWidgetReference Leaf
		{
			get => GetPropertyValue<inkLeafWidgetReference>();
			set => SetPropertyValue<inkLeafWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("Widget")] 
		public inkWidgetReference Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public FUNC_TEST_Container()
		{
			BasePanel = new inkBasePanelWidgetReference();
			Compound = new inkCompoundWidgetReference();
			Leaf = new inkLeafWidgetReference();
			Widget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
