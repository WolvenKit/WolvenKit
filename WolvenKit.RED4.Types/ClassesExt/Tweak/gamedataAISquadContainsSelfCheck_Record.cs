
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadContainsSelfCheck_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("optionalFastExit")]
		[REDProperty(IsIgnored = true)]
		public CBool OptionalFastExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
