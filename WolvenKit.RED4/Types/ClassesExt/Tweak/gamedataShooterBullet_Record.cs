
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterBullet_Record
	{
		[RED("damage")]
		[REDProperty(IsIgnored = true)]
		public CFloat Damage
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
		
		[RED("libraryWidget")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryWidget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("scale")]
		[REDProperty(IsIgnored = true)]
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("specialValue")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpecialValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("speed")]
		[REDProperty(IsIgnored = true)]
		public CFloat Speed
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
