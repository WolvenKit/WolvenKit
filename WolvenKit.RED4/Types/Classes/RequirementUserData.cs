using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequirementUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("skillName")] 
		public CString SkillName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("requiredSkill")] 
		public CInt32 RequiredSkill
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(3)] 
		[RED("isPassed")] 
		public CBool IsPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("asyncSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		public RequirementUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
