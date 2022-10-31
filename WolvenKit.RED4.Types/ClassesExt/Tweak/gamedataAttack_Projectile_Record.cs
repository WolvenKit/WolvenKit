
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_Projectile_Record
	{
		[RED("explosionAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ExplosionAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("projectileTemplateName")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileTemplateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
