using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CursorRootController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("mainCursor")] 
		public inkWidgetReference MainCursor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("progressBar")] 
		public inkWidgetReference ProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("progressBarFrame")] 
		public inkWidgetReference ProgressBarFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CursorRootController()
		{
			MainCursor = new inkWidgetReference();
			ProgressBar = new inkWidgetReference();
			ProgressBarFrame = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
