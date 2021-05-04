using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IllegalActionTypes : CVariable
	{
		private CBool _regularActions;
		private CBool _quickHacks;
		private CBool _skillChecks;

		[Ordinal(0)] 
		[RED("regularActions")] 
		public CBool RegularActions
		{
			get => GetProperty(ref _regularActions);
			set => SetProperty(ref _regularActions, value);
		}

		[Ordinal(1)] 
		[RED("quickHacks")] 
		public CBool QuickHacks
		{
			get => GetProperty(ref _quickHacks);
			set => SetProperty(ref _quickHacks, value);
		}

		[Ordinal(2)] 
		[RED("skillChecks")] 
		public CBool SkillChecks
		{
			get => GetProperty(ref _skillChecks);
			set => SetProperty(ref _skillChecks, value);
		}

		public IllegalActionTypes(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
