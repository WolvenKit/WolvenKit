
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIOptimalDistanceCond_Record
	{
		[RED("checkRings")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CheckRings
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("distanceMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distanceOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat DistanceOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("failWhenCloserThanCurrentRing")]
		[REDProperty(IsIgnored = true)]
		public CBool FailWhenCloserThanCurrentRing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("failWhenFurtherThantCurrentRing")]
		[REDProperty(IsIgnored = true)]
		public CBool FailWhenFurtherThantCurrentRing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("predictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("toleranceMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat ToleranceMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("toleranceOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat ToleranceOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
