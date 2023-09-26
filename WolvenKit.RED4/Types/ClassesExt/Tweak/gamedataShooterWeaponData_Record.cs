
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterWeaponData_Record
	{
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("imageTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ImageTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("imageTexturePart")]
		[REDProperty(IsIgnored = true)]
		public CName ImageTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("interval")]
		[REDProperty(IsIgnored = true)]
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("rounds")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Rounds
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("sfxShoot")]
		[REDProperty(IsIgnored = true)]
		public CName SfxShoot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("specialValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpecialValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("upgradedBulletTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> UpgradedBulletTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("upgradedBulletTexturePart")]
		[REDProperty(IsIgnored = true)]
		public CName UpgradedBulletTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("upgradedValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat UpgradedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
