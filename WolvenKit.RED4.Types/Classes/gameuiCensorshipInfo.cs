using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCensorshipInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("censorFlag")] 
		public CBitField<CensorshipFlags> CensorFlag
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		[Ordinal(1)] 
		[RED("censorFlagAction")] 
		public CEnum<gameuiCharacterCustomizationActionType> CensorFlagAction
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>(value);
		}

		public gameuiCensorshipInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
