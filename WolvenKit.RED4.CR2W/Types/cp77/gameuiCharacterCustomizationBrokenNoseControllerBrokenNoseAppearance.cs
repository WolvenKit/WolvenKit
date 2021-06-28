using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance : CVariable
	{
		private raRef<appearanceAppearanceResource> _resource;
		private CName _definition;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<appearanceAppearanceResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(1)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}

		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
