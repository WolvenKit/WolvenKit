using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAppearanceInfo : gameuiCharacterCustomizationInfo
	{
		private raRef<appearanceAppearanceResource> _resource;
		private CArray<gameuiIndexedAppearanceDefinition> _definitions;
		private CBool _useThumbnails;

		[Ordinal(12)] 
		[RED("resource")] 
		public raRef<appearanceAppearanceResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(13)] 
		[RED("definitions")] 
		public CArray<gameuiIndexedAppearanceDefinition> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}

		[Ordinal(14)] 
		[RED("useThumbnails")] 
		public CBool UseThumbnails
		{
			get => GetProperty(ref _useThumbnails);
			set => SetProperty(ref _useThumbnails, value);
		}

		public gameuiAppearanceInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
