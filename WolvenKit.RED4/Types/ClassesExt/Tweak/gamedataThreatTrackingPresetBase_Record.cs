
namespace WolvenKit.RED4.Types
{
	public partial class gamedataThreatTrackingPresetBase_Record
	{
		[RED("baseAccuracy")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BaseAccuracy
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("baseDroppingThreatCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat BaseDroppingThreatCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("beliefAccuracy")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BeliefAccuracy
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("droppingCooldownPerHit")]
		[REDProperty(IsIgnored = true)]
		public CFloat DroppingCooldownPerHit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("droppingCooldownPerSecondWhileVisible")]
		[REDProperty(IsIgnored = true)]
		public CFloat DroppingCooldownPerSecondWhileVisible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maximumDroppingCooldownValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaximumDroppingCooldownValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("moveBeliefOnlyIfVisible")]
		[REDProperty(IsIgnored = true)]
		public CBool MoveBeliefOnlyIfVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("visibleBeliefSpeedMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisibleBeliefSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
