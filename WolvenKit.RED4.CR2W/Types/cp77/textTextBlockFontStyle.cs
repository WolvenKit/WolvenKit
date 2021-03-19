using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textTextBlockFontStyle : CVariable
	{
		private CName _fontStyle;
		private CInt32 _outlineSize;
		private HDRColor _outlineColor;

		[Ordinal(0)] 
		[RED("fontStyle")] 
		public CName FontStyle
		{
			get => GetProperty(ref _fontStyle);
			set => SetProperty(ref _fontStyle, value);
		}

		[Ordinal(1)] 
		[RED("outlineSize")] 
		public CInt32 OutlineSize
		{
			get => GetProperty(ref _outlineSize);
			set => SetProperty(ref _outlineSize, value);
		}

		[Ordinal(2)] 
		[RED("outlineColor")] 
		public HDRColor OutlineColor
		{
			get => GetProperty(ref _outlineColor);
			set => SetProperty(ref _outlineColor, value);
		}

		public textTextBlockFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
