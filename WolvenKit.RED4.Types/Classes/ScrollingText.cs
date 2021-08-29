using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScrollingText : RedBaseClass
	{
		private CArray<CString> _textArray;

		[Ordinal(0)] 
		[RED("textArray")] 
		public CArray<CString> TextArray
		{
			get => GetProperty(ref _textArray);
			set => SetProperty(ref _textArray, value);
		}
	}
}
