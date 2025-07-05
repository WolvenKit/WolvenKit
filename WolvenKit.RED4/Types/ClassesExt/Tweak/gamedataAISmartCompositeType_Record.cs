
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISmartCompositeType_Record
	{
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("hasMemory")]
		[REDProperty(IsIgnored = true)]
		public CBool HasMemory
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("incrementIteratorOnDeactivation")]
		[REDProperty(IsIgnored = true)]
		public CBool IncrementIteratorOnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("randomizeIteratorOnReset")]
		[REDProperty(IsIgnored = true)]
		public CBool RandomizeIteratorOnReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
