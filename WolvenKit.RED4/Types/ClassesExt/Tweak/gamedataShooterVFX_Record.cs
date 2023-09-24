
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterVFX_Record
	{
		[RED("allowCollision")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("allowLoop")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("allowSelfReset")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowSelfReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("libraryWidget")]
		[REDProperty(IsIgnored = true)]
		public CString LibraryWidget
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
