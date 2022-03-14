
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeFace_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("faceId")]
		[REDProperty(IsIgnored = true)]
		public CInt32 FaceId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("locked")]
		[REDProperty(IsIgnored = true)]
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
