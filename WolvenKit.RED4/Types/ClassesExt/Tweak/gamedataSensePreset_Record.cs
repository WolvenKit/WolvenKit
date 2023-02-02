
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSensePreset_Record
	{
		[RED("curves")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Curves
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("dayNightCurve")]
		[REDProperty(IsIgnored = true)]
		public CName DayNightCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("detectionCoolDownTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionCoolDownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionDifficultyModifierEasy")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionDifficultyModifierEasy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionDifficultyModifierHard")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionDifficultyModifierHard
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionDifficultyModifierNormal")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionDifficultyModifierNormal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionDifficultyModifierVeryHard")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionDifficultyModifierVeryHard
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionDropFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionDropFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detectionPartCoolDownTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetectionPartCoolDownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ignorePhysicsTest")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnorePhysicsTest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("materialCurves")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> MaterialCurves
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("shapes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Shapes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("useZCorrection")]
		[REDProperty(IsIgnored = true)]
		public CBool UseZCorrection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
