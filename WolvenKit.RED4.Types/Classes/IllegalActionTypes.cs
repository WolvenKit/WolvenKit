using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IllegalActionTypes : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("regularActions")] 
		public CBool RegularActions
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("quickHacks")] 
		public CBool QuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("skillChecks")] 
		public CBool SkillChecks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IllegalActionTypes()
		{
			SkillChecks = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
