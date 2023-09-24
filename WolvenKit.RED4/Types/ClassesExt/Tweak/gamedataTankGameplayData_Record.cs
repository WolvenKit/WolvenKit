
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankGameplayData_Record
	{
		[RED("levelList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LevelList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("scoreMultiplierBreakpointList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ScoreMultiplierBreakpointList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("scoreMultiplierDecayBlockedTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat ScoreMultiplierDecayBlockedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("scoreMultiplierDecayRate")]
		[REDProperty(IsIgnored = true)]
		public CFloat ScoreMultiplierDecayRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("worldVelocity")]
		[REDProperty(IsIgnored = true)]
		public Vector2 WorldVelocity
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
	}
}
