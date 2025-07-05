using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MorphMenuUserData : inkUserData
	{
		[Ordinal(0)] 
		[RED("optionsListInitialized")] 
		public CBool OptionsListInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("updatingFinalizedState")] 
		public CBool UpdatingFinalizedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("editMode")] 
		public CEnum<gameuiCharacterCustomizationEditTag> EditMode
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationEditTag>>(value);
		}

		public MorphMenuUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
