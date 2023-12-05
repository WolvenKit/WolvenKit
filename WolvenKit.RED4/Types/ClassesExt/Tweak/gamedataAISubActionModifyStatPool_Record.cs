
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionModifyStatPool_Record
	{
		[RED("amount")]
		[REDProperty(IsIgnored = true)]
		public CFloat Amount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minFallHeightToConsiderInputToggles")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> MinFallHeightToConsiderInputToggles
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("perc")]
		[REDProperty(IsIgnored = true)]
		public CBool Perc
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statPool")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPool
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
