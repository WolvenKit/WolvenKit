using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHudScalingSensitiveWidget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("adjustScale")] 
		public CBool AdjustScale
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("adjustTranslation")] 
		public CBool AdjustTranslation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("adjustMargin")] 
		public CBool AdjustMargin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("targetMarginAtDoubleScale")] 
		public inkMargin TargetMarginAtDoubleScale
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(5)] 
		[RED("marginToScalecorrectOverride")] 
		public inkMargin MarginToScalecorrectOverride
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public gameuiHudScalingSensitiveWidget()
		{
			Widget = new inkWidgetReference();
			TargetMarginAtDoubleScale = new inkMargin();
			MarginToScalecorrectOverride = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
