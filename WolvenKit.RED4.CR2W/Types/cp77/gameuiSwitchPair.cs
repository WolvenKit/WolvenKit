using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitchPair : CVariable
	{
		private wCHandle<gameuiCharacterCustomizationOption> _prevOption;
		private wCHandle<gameuiCharacterCustomizationOption> _currOption;

		[Ordinal(0)] 
		[RED("prevOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> PrevOption
		{
			get => GetProperty(ref _prevOption);
			set => SetProperty(ref _prevOption, value);
		}

		[Ordinal(1)] 
		[RED("currOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> CurrOption
		{
			get => GetProperty(ref _currOption);
			set => SetProperty(ref _currOption, value);
		}

		public gameuiSwitchPair(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
