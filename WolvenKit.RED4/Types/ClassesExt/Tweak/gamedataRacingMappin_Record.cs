
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRacingMappin_Record
	{
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("title")]
		[REDProperty(IsIgnored = true)]
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
