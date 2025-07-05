using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questUIElement_ConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("element")] 
		public TweakDBID Element
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CEnum<gamedataUICondition> Condition
		{
			get => GetPropertyValue<CEnum<gamedataUICondition>>();
			set => SetPropertyValue<CEnum<gamedataUICondition>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questUIElement_ConditionType()
		{
			Condition = Enums.gamedataUICondition.Visible;
			Value = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
