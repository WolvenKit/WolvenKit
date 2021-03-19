using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSnapTags : CVariable
	{
		private CArray<CName> _includeTags;
		private CArray<CName> _excludeTags;

		[Ordinal(0)] 
		[RED("includeTags")] 
		public CArray<CName> IncludeTags
		{
			get => GetProperty(ref _includeTags);
			set => SetProperty(ref _includeTags, value);
		}

		[Ordinal(1)] 
		[RED("excludeTags")] 
		public CArray<CName> ExcludeTags
		{
			get => GetProperty(ref _excludeTags);
			set => SetProperty(ref _excludeTags, value);
		}

		public worldSnapTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
