
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemRequiredSlot_Record
	{
		[RED("attachmentSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttachmentSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
