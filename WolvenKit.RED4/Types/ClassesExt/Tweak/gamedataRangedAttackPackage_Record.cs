
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRangedAttackPackage_Record
	{
		[RED("chargeFire")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ChargeFire
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("defaultFire")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultFire
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
