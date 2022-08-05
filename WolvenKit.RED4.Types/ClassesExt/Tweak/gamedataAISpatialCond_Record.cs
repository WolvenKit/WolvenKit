
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISpatialCond_Record
	{
		[RED("angleDirection")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AngleDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("coneAngle")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ConeAngle
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Distance
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
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
		
		[RED("spatialHintMults")]
		[REDProperty(IsIgnored = true)]
		public Vector3 SpatialHintMults
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetOpt")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TargetOpt
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useTargetPOV")]
		[REDProperty(IsIgnored = true)]
		public CBool UseTargetPOV
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("zDiff")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ZDiff
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
