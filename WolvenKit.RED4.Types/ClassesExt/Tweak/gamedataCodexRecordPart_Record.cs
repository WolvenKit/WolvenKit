
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCodexRecordPart_Record
	{
		[RED("partContent")]
		[REDProperty(IsIgnored = true)]
		public CString PartContent
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("partName")]
		[REDProperty(IsIgnored = true)]
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
