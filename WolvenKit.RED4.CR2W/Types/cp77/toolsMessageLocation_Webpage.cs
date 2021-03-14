using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_Webpage : toolsIMessageLocation
	{
		private CString _link;
		private CString _text;

		[Ordinal(0)] 
		[RED("link")] 
		public CString Link
		{
			get
			{
				if (_link == null)
				{
					_link = (CString) CR2WTypeManager.Create("String", "link", cr2w, this);
				}
				return _link;
			}
			set
			{
				if (_link == value)
				{
					return;
				}
				_link = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		public toolsMessageLocation_Webpage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
