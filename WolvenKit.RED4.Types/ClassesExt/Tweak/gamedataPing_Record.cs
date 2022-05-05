
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPing_Record
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
		
		[RED("lifeSpan")]
		[REDProperty(IsIgnored = true)]
		public CFloat LifeSpan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minimapIconName")]
		[REDProperty(IsIgnored = true)]
		public CName MinimapIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("voTriggerName")]
		[REDProperty(IsIgnored = true)]
		public CName VoTriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("worldIconName")]
		[REDProperty(IsIgnored = true)]
		public CName WorldIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
