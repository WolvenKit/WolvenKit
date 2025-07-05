
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIVelocitiesDotCond_Record
	{
		[RED("dotRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 DotRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("firstTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FirstTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("firstTimePeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat FirstTimePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("secondTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("secondTimePeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat SecondTimePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
