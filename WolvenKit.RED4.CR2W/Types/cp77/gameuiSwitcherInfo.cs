using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		private CArray<gameuiSwitcherOption> _options;
		private CBool _switchVisibility;

		[Ordinal(12)] 
		[RED("options")] 
		public CArray<gameuiSwitcherOption> Options
		{
			get => GetProperty(ref _options);
			set => SetProperty(ref _options, value);
		}

		[Ordinal(13)] 
		[RED("switchVisibility")] 
		public CBool SwitchVisibility
		{
			get => GetProperty(ref _switchVisibility);
			set => SetProperty(ref _switchVisibility, value);
		}

		public gameuiSwitcherInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
