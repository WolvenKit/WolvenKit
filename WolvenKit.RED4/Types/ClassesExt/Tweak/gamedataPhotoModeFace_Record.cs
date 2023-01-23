
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeFace_Record
	{
		[RED("faceId")]
		[REDProperty(IsIgnored = true)]
		public CInt32 FaceId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
