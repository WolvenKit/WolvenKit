
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIMovingInCirclesCond_Record
	{
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("time")]
		[REDProperty(IsIgnored = true)]
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
