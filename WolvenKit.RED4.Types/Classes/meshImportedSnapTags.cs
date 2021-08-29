using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshImportedSnapTags : RedBaseClass
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
	}
}
