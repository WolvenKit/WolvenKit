using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionSkillCheck : ActionBool
	{
		private CHandle<SkillCheckBase> _skillCheck;
		private CEnum<EDeviceChallengeSkill> _skillCheckName;
		private CString _localizedName;
		private UIInteractionSkillCheck _skillcheckDescription;
		private CBool _wasPassed;
		private CBool _availableUnpowered;

		[Ordinal(25)] 
		[RED("skillCheck")] 
		public CHandle<SkillCheckBase> SkillCheck
		{
			get => GetProperty(ref _skillCheck);
			set => SetProperty(ref _skillCheck, value);
		}

		[Ordinal(26)] 
		[RED("skillCheckName")] 
		public CEnum<EDeviceChallengeSkill> SkillCheckName
		{
			get => GetProperty(ref _skillCheckName);
			set => SetProperty(ref _skillCheckName, value);
		}

		[Ordinal(27)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(28)] 
		[RED("skillcheckDescription")] 
		public UIInteractionSkillCheck SkillcheckDescription
		{
			get => GetProperty(ref _skillcheckDescription);
			set => SetProperty(ref _skillcheckDescription, value);
		}

		[Ordinal(29)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get => GetProperty(ref _wasPassed);
			set => SetProperty(ref _wasPassed, value);
		}

		[Ordinal(30)] 
		[RED("availableUnpowered")] 
		public CBool AvailableUnpowered
		{
			get => GetProperty(ref _availableUnpowered);
			set => SetProperty(ref _availableUnpowered, value);
		}

		public ActionSkillCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
