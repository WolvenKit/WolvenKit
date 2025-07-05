
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionTriggerStim_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("direct")]
		[REDProperty(IsIgnored = true)]
		public CBool Direct
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("purelyDirect")]
		[REDProperty(IsIgnored = true)]
		public CBool PurelyDirect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stimSource")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StimSource
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stimType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StimType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
