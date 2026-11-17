using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioToolTipInMenu : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("mainContainer")] 
		public inkWidgetReference MainContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("content")] 
		public inkTextWidgetReference Content
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("TopMargin")] 
		public inkCanvasWidgetReference TopMargin
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		public ModioToolTipInMenu()
		{
			MainContainer = new inkWidgetReference();
			Content = new inkTextWidgetReference();
			TopMargin = new inkCanvasWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
