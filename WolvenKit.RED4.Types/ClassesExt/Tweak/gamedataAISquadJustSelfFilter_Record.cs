
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadJustSelfFilter_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("resetMembers")]
		[REDProperty(IsIgnored = true)]
		public CBool ResetMembers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("resetMembersIncludingUnwillings")]
		[REDProperty(IsIgnored = true)]
		public CBool ResetMembersIncludingUnwillings
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("skipSelfOnce")]
		[REDProperty(IsIgnored = true)]
		public CBool SkipSelfOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
