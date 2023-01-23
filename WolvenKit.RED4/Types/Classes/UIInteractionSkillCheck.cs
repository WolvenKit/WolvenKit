using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInteractionSkillCheck : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(2)] 
		[RED("skillName")] 
		public CString SkillName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("requiredSkill")] 
		public CInt32 RequiredSkill
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("playerSkill")] 
		public CInt32 PlayerSkill
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("actionDisplayName")] 
		public CString ActionDisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("hasAdditionalRequirements")] 
		public CBool HasAdditionalRequirements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("additionalReqOperator")] 
		public CEnum<ELogicOperator> AdditionalReqOperator
		{
			get => GetPropertyValue<CEnum<ELogicOperator>>();
			set => SetPropertyValue<CEnum<ELogicOperator>>(value);
		}

		[Ordinal(8)] 
		[RED("additionalRequirements")] 
		public CArray<ConditionData> AdditionalRequirements
		{
			get => GetPropertyValue<CArray<ConditionData>>();
			set => SetPropertyValue<CArray<ConditionData>>(value);
		}

		[Ordinal(9)] 
		[RED("isPassed")] 
		public CBool IsPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public UIInteractionSkillCheck()
		{
			AdditionalRequirements = new();
			OwnerID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
