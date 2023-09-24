
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankProjectile_Record
	{
		[RED("damage")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Damage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("velocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Velocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
