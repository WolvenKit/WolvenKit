using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVisualTagAppearanceGroup : CVariable
	{
		private CArray<CName> _appearances;
		private CArray<CName> _visualTags;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("visualTags")] 
		public CArray<CName> VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		public audioVisualTagAppearanceGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
