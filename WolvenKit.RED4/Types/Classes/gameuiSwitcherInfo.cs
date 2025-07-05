using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(13)] 
		[RED("uiSlots")] 
		public CArray<CName> UiSlots
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(14)] 
		[RED("options")] 
		public CArray<gameuiSwitcherOption> Options
		{
			get => GetPropertyValue<CArray<gameuiSwitcherOption>>();
			set => SetPropertyValue<CArray<gameuiSwitcherOption>>(value);
		}

		[Ordinal(15)] 
		[RED("switchVisibility")] 
		public CBool SwitchVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiSwitcherInfo()
		{
			Enabled = true;
			EditTags = new();
			OnDeactivateActions = new();
			UiSlots = new();
			Options = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
