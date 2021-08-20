using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequirementUserData : IScriptable
	{
		private CString _skillName;
		private CInt32 _requiredSkill;
		private CEnum<EDeviceChallengeSkill> _skillCheck;
		private CBool _isPassed;
		private wCHandle<inkAsyncSpawnRequest> _asyncSpawnRequest;

		[Ordinal(0)] 
		[RED("skillName")] 
		public CString SkillName
		{
			get => GetProperty(ref _skillName);
			set => SetProperty(ref _skillName, value);
		}

		[Ordinal(1)] 
		[RED("requiredSkill")] 
		public CInt32 RequiredSkill
		{
			get => GetProperty(ref _requiredSkill);
			set => SetProperty(ref _requiredSkill, value);
		}

		[Ordinal(2)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		[Ordinal(3)] 
		[RED("isPassed")] 
		public CBool IsPassed
		{
			get => GetProperty(ref _isPassed);
			set => SetProperty(ref _isPassed, value);
		}

		[Ordinal(4)] 
		[RED("asyncSpawnRequest")] 
		public wCHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetProperty(ref _asyncSpawnRequest);
			set => SetProperty(ref _asyncSpawnRequest, value);
		}

		public RequirementUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
