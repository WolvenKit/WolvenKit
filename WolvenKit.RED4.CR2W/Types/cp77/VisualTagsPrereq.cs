using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VisualTagsPrereq : gameIScriptablePrereq
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

		public VisualTagsPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
