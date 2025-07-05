
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterProp_Record
	{
		[RED("explosionDamage")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExplosionDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("explosionRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExplosionRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
