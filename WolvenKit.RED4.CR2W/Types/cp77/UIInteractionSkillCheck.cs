using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInteractionSkillCheck : CVariable
	{
		private CBool _isValid;
		private CEnum<EDeviceChallengeSkill> _skillCheck;
		private CString _skillName;
		private CInt32 _requiredSkill;
		private CInt32 _playerSkill;
		private CString _actionDisplayName;
		private CBool _hasAdditionalRequirements;
		private CEnum<ELogicOperator> _additionalReqOperator;
		private CArray<ConditionData> _additionalRequirements;
		private CBool _isPassed;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get => GetProperty(ref _isValid);
			set => SetProperty(ref _isValid, value);
		}

		[Ordinal(1)] 
		[RED("skillCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		[Ordinal(2)] 
		[RED("skillName")] 
		public CString SkillName
		{
			get => GetProperty(ref _skillName);
			set => SetProperty(ref _skillName, value);
		}

		[Ordinal(3)] 
		[RED("requiredSkill")] 
		public CInt32 RequiredSkill
		{
			get => GetProperty(ref _requiredSkill);
			set => SetProperty(ref _requiredSkill, value);
		}

		[Ordinal(4)] 
		[RED("playerSkill")] 
		public CInt32 PlayerSkill
		{
			get => GetProperty(ref _playerSkill);
			set => SetProperty(ref _playerSkill, value);
		}

		[Ordinal(5)] 
		[RED("actionDisplayName")] 
		public CString ActionDisplayName
		{
			get => GetProperty(ref _actionDisplayName);
			set => SetProperty(ref _actionDisplayName, value);
		}

		[Ordinal(6)] 
		[RED("hasAdditionalRequirements")] 
		public CBool HasAdditionalRequirements
		{
			get => GetProperty(ref _hasAdditionalRequirements);
			set => SetProperty(ref _hasAdditionalRequirements, value);
		}

		[Ordinal(7)] 
		[RED("additionalReqOperator")] 
		public CEnum<ELogicOperator> AdditionalReqOperator
		{
			get => GetProperty(ref _additionalReqOperator);
			set => SetProperty(ref _additionalReqOperator, value);
		}

		[Ordinal(8)] 
		[RED("additionalRequirements")] 
		public CArray<ConditionData> AdditionalRequirements
		{
			get => GetProperty(ref _additionalRequirements);
			set => SetProperty(ref _additionalRequirements, value);
		}

		[Ordinal(9)] 
		[RED("isPassed")] 
		public CBool IsPassed
		{
			get => GetProperty(ref _isPassed);
			set => SetProperty(ref _isPassed, value);
		}

		[Ordinal(10)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		public UIInteractionSkillCheck(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
