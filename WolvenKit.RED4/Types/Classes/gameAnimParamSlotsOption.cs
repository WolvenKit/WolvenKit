using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimParamSlotsOption : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("function")] 
		public CEnum<entAnimParamSlotFunction> Function
		{
			get => GetPropertyValue<CEnum<entAnimParamSlotFunction>>();
			set => SetPropertyValue<CEnum<entAnimParamSlotFunction>>(value);
		}

		public gameAnimParamSlotsOption()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
