using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationBodyMorphBaseOption : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("isPrevOrNextBtnHoveredOver")] 
		public CBool IsPrevOrNextBtnHoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CharacterCreationBodyMorphBaseOption()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
