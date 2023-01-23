
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStim_Record
	{
		[RED("aggressive")]
		[REDProperty(IsIgnored = true)]
		public CFloat Aggressive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("category")]
		[REDProperty(IsIgnored = true)]
		public CName Category
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("fear")]
		[REDProperty(IsIgnored = true)]
		public CFloat Fear
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("interval")]
		[REDProperty(IsIgnored = true)]
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isReactionStim")]
		[REDProperty(IsIgnored = true)]
		public CBool IsReactionStim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Priority
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("propagation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Propagation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("targets")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Targets
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
