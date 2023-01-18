
namespace WolvenKit.RED4.Types
{
	public partial class gamedataProjectileCollision_Record
	{
		[RED("canStopAndStickOnHardSurfaces")]
		[REDProperty(IsIgnored = true)]
		public CBool CanStopAndStickOnHardSurfaces
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("energyLossFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat EnergyLossFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
