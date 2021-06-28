using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage1App;
		private gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance _stage2App;

		[Ordinal(3)] 
		[RED("stage1App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App
		{
			get => GetProperty(ref _stage1App);
			set => SetProperty(ref _stage1App, value);
		}

		[Ordinal(4)] 
		[RED("stage2App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App
		{
			get => GetProperty(ref _stage2App);
			set => SetProperty(ref _stage2App, value);
		}

		public gameuiCharacterCustomizationBrokenNoseController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
