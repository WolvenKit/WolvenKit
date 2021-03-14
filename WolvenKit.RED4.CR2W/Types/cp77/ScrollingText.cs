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
			get
			{
				if (_textArray == null)
				{
					_textArray = (CArray<CString>) CR2WTypeManager.Create("array:String", "textArray", cr2w, this);
				}
				return _textArray;
			}
			set
			{
				if (_textArray == value)
				{
					return;
				}
				_textArray = value;
				PropertySet(this);
			}
		}

		public ScrollingText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
