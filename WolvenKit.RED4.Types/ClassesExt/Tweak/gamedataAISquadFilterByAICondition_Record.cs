
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadFilterByAICondition_Record
	{
		[RED("condition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Condition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
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
