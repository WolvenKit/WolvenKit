using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScrollingText : CVariable
	{
		private CArray<CString> _textArray;

		[Ordinal(0)] 
		[RED("textArray")] 
		public CArray<CString> TextArray
		{
			get => GetProperty(ref _textArray);
			set => SetProperty(ref _textArray, value);
		}

		public ScrollingText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
