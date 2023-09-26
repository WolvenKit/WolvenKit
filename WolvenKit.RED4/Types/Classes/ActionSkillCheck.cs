using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionSkillCheck : ActionBool
	{
		[Ordinal(38)] 
		[RED("skillCheck")] 
		public CHandle<SkillCheckBase> SkillCheck
		{
			get => GetPropertyValue<CHandle<SkillCheckBase>>();
			set => SetPropertyValue<CHandle<SkillCheckBase>>(value);
		}

		[Ordinal(39)] 
		[RED("skillCheckName")] 
		public CEnum<EDeviceChallengeSkill> SkillCheckName
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(40)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(41)] 
		[RED("skillcheckDescription")] 
		public UIInteractionSkillCheck SkillcheckDescription
		{
			get => GetPropertyValue<UIInteractionSkillCheck>();
			set => SetPropertyValue<UIInteractionSkillCheck>(value);
		}

		[Ordinal(42)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
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
