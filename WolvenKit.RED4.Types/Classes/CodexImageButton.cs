using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexImageButton : CodexListItemController
	{
		private inkImageWidgetReference _image;
		private inkImageWidgetReference _border;
		private inkWidgetReference _translateOnSelect;
		private CFloat _selectTranslationX;

		[Ordinal(19)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(20)] 
		[RED("border")] 
		public inkImageWidgetReference Border
		{
			get => GetProperty(ref _border);
			set => SetProperty(ref _border, value);
		}

		[Ordinal(21)] 
		[RED("translateOnSelect")] 
		public inkWidgetReference TranslateOnSelect
		{
			get => GetProperty(ref _translateOnSelect);
			set => SetProperty(ref _translateOnSelect, value);
		}

		[Ordinal(22)] 
		[RED("selectTranslationX")] 
		public CFloat SelectTranslationX
		{
			get => GetProperty(ref _selectTranslationX);
			set => SetProperty(ref _selectTranslationX, value);
		}
	}
}
