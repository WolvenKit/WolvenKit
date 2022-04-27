
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPerkPrereq_Record
	{
		[RED("perk")]
		[REDProperty(IsIgnored = true)]
		public CString Perk
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
