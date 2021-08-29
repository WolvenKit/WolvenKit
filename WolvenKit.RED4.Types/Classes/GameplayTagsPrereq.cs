using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayTagsPrereq : gameIScriptablePrereq
	{
		private CArray<CName> _allowedTags;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("allowedTags")] 
		public CArray<CName> AllowedTags
		{
			get => GetProperty(ref _allowedTags);
			set => SetProperty(ref _allowedTags, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
