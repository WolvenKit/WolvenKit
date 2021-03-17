using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsSetVisibility : redEvent
	{
		private CBool _visible;
		private CEnum<entVisibilityParamSource> _source;

		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CEnum<entVisibilityParamSource> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public enteventsSetVisibility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
