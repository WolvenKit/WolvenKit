
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetStimSource_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("revertStimSourceDirection")]
		[REDProperty(IsIgnored = true)]
		public CBool RevertStimSourceDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stimTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StimTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useInvestigateData")]
		[REDProperty(IsIgnored = true)]
		public CBool UseInvestigateData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
