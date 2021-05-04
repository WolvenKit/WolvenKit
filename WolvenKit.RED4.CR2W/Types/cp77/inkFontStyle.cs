using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontStyle : CVariable
	{
		private CName _styleName;
		private rRef<rendFont> _font;

		[Ordinal(0)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get => GetProperty(ref _styleName);
			set => SetProperty(ref _styleName, value);
		}

		[Ordinal(1)] 
		[RED("font")] 
		public rRef<rendFont> Font
		{
			get => GetProperty(ref _font);
			set => SetProperty(ref _font, value);
		}

		public inkFontStyle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
