
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionFastExitWorkspot_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("destinationObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DestinationObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("playSlowExitIfFailed")]
		[REDProperty(IsIgnored = true)]
		public CBool PlaySlowExitIfFailed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stayInWorkspotIfFailed")]
		[REDProperty(IsIgnored = true)]
		public CBool StayInWorkspotIfFailed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
