
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChoiceCaptionTagPart_Record
	{
		[RED("partType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PartType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tagLocId")]
		[REDProperty(IsIgnored = true)]
		public CString TagLocId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
