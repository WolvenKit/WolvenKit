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

		public toolsMessageLocation_Webpage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
