
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemPartConnection_Record
	{
		[RED("attachmentSlot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttachmentSlot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("child")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Child
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("parent")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Parent
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
