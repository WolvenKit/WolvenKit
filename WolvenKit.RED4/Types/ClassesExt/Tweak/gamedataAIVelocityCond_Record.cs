
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIVelocityCond_Record
	{
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Range
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("timePeriod")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimePeriod
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
