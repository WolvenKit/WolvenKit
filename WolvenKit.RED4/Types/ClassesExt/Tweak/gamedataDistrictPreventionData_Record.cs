
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDistrictPreventionData_Record
	{
		[RED("blinkingStarsDurationTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlinkingStarsDurationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blinkThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlinkThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("damagePercentThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat DamagePercentThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("deescalationZeroTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeescalationZeroTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("exteriorSpawnDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExteriorSpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("heat1")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Heat1
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("heat2")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Heat2
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("heat3")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Heat3
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("heat4")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Heat4
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("inputLockOverrideThreshold")]
		[REDProperty(IsIgnored = true)]
		public CInt32 InputLockOverrideThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("inputLockTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat InputLockTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("interiorSpawnDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat InteriorSpawnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("nonAggressiveReactionMultipler")]
		[REDProperty(IsIgnored = true)]
		public CFloat NonAggressiveReactionMultipler
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("recon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Recon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("safeDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SafeDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnOriginMaxDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnOriginMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
