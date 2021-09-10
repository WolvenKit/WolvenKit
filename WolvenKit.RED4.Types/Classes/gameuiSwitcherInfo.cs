using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(12)] 
		[RED("options")] 
		public CArray<gameuiSwitcherOption> Options
		{
			get => GetPropertyValue<CArray<gameuiSwitcherOption>>();
			set => SetPropertyValue<CArray<gameuiSwitcherOption>>(value);
		}

		[Ordinal(13)] 
		[RED("switchVisibility")] 
		public CBool SwitchVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiSwitcherInfo()
		{
			Enabled = true;
			OnDeactivateActions = new();
			Options = new();
		}
	}
}
