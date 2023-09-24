
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDistrictPreventionData_Record
	{
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
		
		[RED("heat5")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Heat5
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
		
		[RED("recon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Recon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
