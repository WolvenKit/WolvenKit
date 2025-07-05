
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCoverSelectionParameters_Record
	{
		[RED("scoreOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool ScoreOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vaidateOnlyForCombatTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool VaidateOnlyForCombatTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
