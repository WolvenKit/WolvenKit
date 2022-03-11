
namespace WolvenKit.RED4.Types
{
	public partial class gamedataActionRestrictionGroup_Record
	{
		[RED("allowedActionNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> AllowedActionNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("disallowedActionNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> DisallowedActionNames
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("inactiveReason")]
		[REDProperty(IsIgnored = true)]
		public CString InactiveReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
