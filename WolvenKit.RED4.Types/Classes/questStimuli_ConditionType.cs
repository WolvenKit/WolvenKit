using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStimuli_ConditionType : questISensesConditionType
	{
		[Ordinal(0)] 
		[RED("instigatorRef")] 
		public gameEntityReference InstigatorRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayerInstigator")] 
		public CBool IsPlayerInstigator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStimType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		public questStimuli_ConditionType()
		{
			InstigatorRef = new() { Names = new() };
			IsPlayerInstigator = true;
			TargetRef = new() { Names = new() };
			Type = Enums.gamedataStimType.FootStepRegular;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
