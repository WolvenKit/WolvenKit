using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckYaibaOption : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("checkBox")] 
		public inkWidgetReference CheckBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("checkMark")] 
		public inkWidgetReference CheckMark
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("option")] 
		public CEnum<MuramasaOption> Option
		{
			get => GetPropertyValue<CEnum<MuramasaOption>>();
			set => SetPropertyValue<CEnum<MuramasaOption>>(value);
		}

		[Ordinal(4)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("isChecked")] 
		public CBool IsChecked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("previewController")] 
		public CWeakHandle<YaibaOptionPreview> PreviewController
		{
			get => GetPropertyValue<CWeakHandle<YaibaOptionPreview>>();
			set => SetPropertyValue<CWeakHandle<YaibaOptionPreview>>(value);
		}

		public CheckYaibaOption()
		{
			CheckBox = new inkWidgetReference();
			CheckMark = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
