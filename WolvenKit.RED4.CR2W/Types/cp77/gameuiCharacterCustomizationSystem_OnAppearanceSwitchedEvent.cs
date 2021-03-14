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
			get
			{
				if (_pairs == null)
				{
					_pairs = (CArray<gameuiSwitchPair>) CR2WTypeManager.Create("array:gameuiSwitchPair", "pairs", cr2w, this);
				}
				return _pairs;
			}
			set
			{
				if (_pairs == value)
				{
					return;
				}
				_pairs = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationSystem_OnAppearanceSwitchedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
