using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageButtonCustomData : WidgetCustomData
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

		public ImageButtonCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
