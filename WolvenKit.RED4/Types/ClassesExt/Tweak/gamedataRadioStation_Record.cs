
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRadioStation_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("icon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("index")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
