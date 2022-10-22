
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIActionSelector_Record
	{
		[RED("actions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Actions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("defaultAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("disableActionsLimit")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableActionsLimit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("failOnNodeActivationConditionFailure")]
		[REDProperty(IsIgnored = true)]
		public CBool FailOnNodeActivationConditionFailure
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
