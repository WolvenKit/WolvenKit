using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IllegalActionTypes : RedBaseClass
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

		public IllegalActionTypes()
		{
			_skillChecks = true;
		}
	}
}
