using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessageLocation_Webpage : toolsIMessageLocation
	{
		private CString _link;
		private CString _text;

		[Ordinal(0)] 
		[RED("link")] 
		public CString Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}
	}
}
