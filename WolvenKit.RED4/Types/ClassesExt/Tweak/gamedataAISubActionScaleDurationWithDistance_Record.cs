
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionScaleDurationWithDistance_Record
	{
		[RED("distanceRange")]
		[REDProperty(IsIgnored = true)]
		public Vector2 DistanceRange
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("scaleDistanceToTime")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ScaleDistanceToTime
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("source")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Source
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
