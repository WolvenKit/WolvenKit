using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationAction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiCharacterCustomizationActionType> Type
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CString Params
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("applyToUISlot")] 
		public CBool ApplyToUISlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("applyImmediately")] 
		public CBool ApplyImmediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharacterCustomizationAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
