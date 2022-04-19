using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProgressBarButton : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("craftingFill")] 
		public inkWidgetReference CraftingFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("craftingLabel")] 
		public inkTextWidgetReference CraftingLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(4)] 
		[RED("progressController")] 
		public CWeakHandle<ProgressBarsController> ProgressController
		{
			get => GetPropertyValue<CWeakHandle<ProgressBarsController>>();
			set => SetPropertyValue<CWeakHandle<ProgressBarsController>>(value);
		}

		[Ordinal(5)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ProgressBarButton()
		{
			CraftingFill = new();
			CraftingLabel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
