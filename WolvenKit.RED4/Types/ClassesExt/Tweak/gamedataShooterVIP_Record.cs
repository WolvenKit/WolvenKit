
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterVIP_Record
	{
		[RED("spawnDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
