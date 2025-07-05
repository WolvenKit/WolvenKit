
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChoiceCaptionTagPart_Record
	{
		[RED("tagLocId")]
		[REDProperty(IsIgnored = true)]
		public CString TagLocId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
