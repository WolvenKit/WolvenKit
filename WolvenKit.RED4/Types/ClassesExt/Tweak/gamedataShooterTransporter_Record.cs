
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterTransporter_Record
	{
		[RED("dropSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat DropSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
