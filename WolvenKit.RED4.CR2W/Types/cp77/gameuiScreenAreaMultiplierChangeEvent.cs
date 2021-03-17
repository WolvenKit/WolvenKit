using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiScreenAreaMultiplierChangeEvent : redEvent
	{
		private CFloat _screenAreaMultiplier;

		[Ordinal(0)] 
		[RED("screenAreaMultiplier")] 
		public CFloat ScreenAreaMultiplier
		{
			get => GetProperty(ref _screenAreaMultiplier);
			set => SetProperty(ref _screenAreaMultiplier, value);
		}

		public gameuiScreenAreaMultiplierChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
