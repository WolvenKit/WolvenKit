
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRipperdocMappin_Record
	{
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
