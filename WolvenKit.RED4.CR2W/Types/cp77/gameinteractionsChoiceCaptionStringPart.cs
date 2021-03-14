using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionStringPart : gameinteractionsChoiceCaptionPart
	{
		private CString _content;

		[Ordinal(0)] 
		[RED("content")] 
		public CString Content
		{
			get
			{
				if (_content == null)
				{
					_content = (CString) CR2WTypeManager.Create("String", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoiceCaptionStringPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
