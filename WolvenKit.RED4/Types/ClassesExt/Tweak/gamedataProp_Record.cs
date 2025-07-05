
namespace WolvenKit.RED4.Types
{
	public partial class gamedataProp_Record
	{
		[RED("friendlyName")]
		[REDProperty(IsIgnored = true)]
		public CString FriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
