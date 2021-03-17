using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent : redEvent
	{
		private CArray<gameuiSwitchPair> _pairs;

		[Ordinal(0)] 
		[RED("pairs")] 
		public CArray<gameuiSwitchPair> Pairs
		{
			get => GetProperty(ref _pairs);
			set => SetProperty(ref _pairs, value);
		}

		public gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
