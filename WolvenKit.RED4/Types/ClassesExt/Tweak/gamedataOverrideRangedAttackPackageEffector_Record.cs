
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOverrideRangedAttackPackageEffector_Record
	{
		[RED("attackPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
