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
		[RED("craftingIconGlyph")] 
		public inkWidgetReference CraftingIconGlyph
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ButtonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(5)] 
		[RED("progressController")] 
		public CWeakHandle<ProgressBarsController> ProgressController
		{
			get => GetPropertyValue<CWeakHandle<ProgressBarsController>>();
			set => SetPropertyValue<CWeakHandle<ProgressBarsController>>(value);
		}

		[Ordinal(6)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProgressBarButton()
		{
			CraftingFill = new inkWidgetReference();
			CraftingLabel = new inkTextWidgetReference();
			CraftingIconGlyph = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
