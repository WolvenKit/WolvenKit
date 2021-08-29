using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexEntryData : GenericCodexEntryData
	{
		private CInt32 _category;
		private CEnum<CodexImageType> _imageType;

		[Ordinal(10)] 
		[RED("category")] 
		public CInt32 Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(11)] 
		[RED("imageType")] 
		public CEnum<CodexImageType> ImageType
		{
			get => GetProperty(ref _imageType);
			set => SetProperty(ref _imageType, value);
		}
	}
}
