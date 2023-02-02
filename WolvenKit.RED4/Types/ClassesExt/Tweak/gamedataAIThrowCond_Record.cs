
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIThrowCond_Record
	{
		[RED("clearLOSDistanceTolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ClearLOSDistanceTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("predictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PredictionTime
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
		
		[RED("throwAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ThrowAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WeaponSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
