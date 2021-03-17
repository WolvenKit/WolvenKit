using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentBalanced_ScriptConditionType : PaymentConditionTypeBase
	{
		private TweakDBID _questAssignment;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(2)] 
		[RED("questAssignment")] 
		public TweakDBID QuestAssignment
		{
			get => GetProperty(ref _questAssignment);
			set => SetProperty(ref _questAssignment, value);
		}

		[Ordinal(3)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public PaymentBalanced_ScriptConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
