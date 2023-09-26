
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterProjectileAI_Record
	{
		[RED("fireDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat FireDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
