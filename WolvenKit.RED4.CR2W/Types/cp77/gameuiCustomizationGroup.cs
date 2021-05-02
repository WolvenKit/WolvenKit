using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationGroup : CVariable
	{
		private CName _name;
		private CArray<gameuiCustomizationAppearance> _customization;
		private CArray<gameuiCustomizationMorph> _morphs;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("customization")] 
		public CArray<gameuiCustomizationAppearance> Customization
		{
			get => GetProperty(ref _customization);
			set => SetProperty(ref _customization, value);
		}

		[Ordinal(2)] 
		[RED("morphs")] 
		public CArray<gameuiCustomizationMorph> Morphs
		{
			get => GetProperty(ref _morphs);
			set => SetProperty(ref _morphs, value);
		}

		public gameuiCustomizationGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
