
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterAI_Record
	{
		[RED("collisionDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat CollisionDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("health")]
		[REDProperty(IsIgnored = true)]
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("libraryWidget")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryWidget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("moveSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MoveSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sfxDamage")]
		[REDProperty(IsIgnored = true)]
		public CName SfxDamage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sfxDead")]
		[REDProperty(IsIgnored = true)]
		public CName SfxDead
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
