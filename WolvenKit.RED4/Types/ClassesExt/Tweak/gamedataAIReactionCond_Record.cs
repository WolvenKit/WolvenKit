
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIReactionCond_Record
	{
		[RED("investigateController")]
		[REDProperty(IsIgnored = true)]
		public CBool InvestigateController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("preset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Preset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("reactionBehaviorName")]
		[REDProperty(IsIgnored = true)]
		public CName ReactionBehaviorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("stimType")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StimType
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("thresholdValue")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ThresholdValue
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("validStimPosition")]
		[REDProperty(IsIgnored = true)]
		public CBool ValidStimPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
