using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationUiPresetInfo : CVariable
	{
		private CName _name;
		private raRef<gameuiCharacterCustomizationUiPreset> _resource;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public raRef<gameuiCharacterCustomizationUiPreset> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		public gameuiCharacterCustomizationUiPresetInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
