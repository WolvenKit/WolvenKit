using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkSettingsSelectorControllerKeyBinding : inkSettingsSelectorController
	{
		private inkRichTextBoxWidgetReference _text;
		private inkWidgetReference _buttonRef;
		private inkWidgetReference _editView;
		private CFloat _editOpacity;

		[Ordinal(15)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(16)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		[Ordinal(17)] 
		[RED("editView")] 
		public inkWidgetReference EditView
		{
			get => GetProperty(ref _editView);
			set => SetProperty(ref _editView, value);
		}

		[Ordinal(18)] 
		[RED("editOpacity")] 
		public CFloat EditOpacity
		{
			get => GetProperty(ref _editOpacity);
			set => SetProperty(ref _editOpacity, value);
		}
	}
}
