using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageButtonCustomData : WidgetCustomData
	{
		private CName _imageAtlasImageID;
		private CString _additionalText;

		[Ordinal(0)] 
		[RED("imageAtlasImageID")] 
		public CName ImageAtlasImageID
		{
			get => GetProperty(ref _imageAtlasImageID);
			set => SetProperty(ref _imageAtlasImageID, value);
		}

		[Ordinal(1)] 
		[RED("additionalText")] 
		public CString AdditionalText
		{
			get => GetProperty(ref _additionalText);
			set => SetProperty(ref _additionalText, value);
		}
	}
}
