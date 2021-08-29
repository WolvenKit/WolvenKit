using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
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
	}
}
