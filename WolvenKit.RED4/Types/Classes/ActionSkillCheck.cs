using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionSkillCheck : ActionBool
	{
		[Ordinal(25)] 
		[RED("skillCheck")] 
		public CHandle<SkillCheckBase> SkillCheck
		{
			get => GetPropertyValue<CHandle<SkillCheckBase>>();
			set => SetPropertyValue<CHandle<SkillCheckBase>>(value);
		}

		[Ordinal(26)] 
		[RED("skillCheckName")] 
		public CEnum<EDeviceChallengeSkill> SkillCheckName
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(27)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(28)] 
		[RED("skillcheckDescription")] 
		public UIInteractionSkillCheck SkillcheckDescription
		{
			get => GetPropertyValue<UIInteractionSkillCheck>();
			set => SetPropertyValue<UIInteractionSkillCheck>(value);
		}

		[Ordinal(29)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("availableUnpowered")] 
		public CBool AvailableUnpowered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActionSkillCheck()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
