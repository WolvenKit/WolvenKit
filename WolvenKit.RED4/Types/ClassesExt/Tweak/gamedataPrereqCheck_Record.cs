
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPrereqCheck_Record
	{
		[RED("comparisonType")]
		[REDProperty(IsIgnored = true)]
		public CString ComparisonType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("contextObject")]
		[REDProperty(IsIgnored = true)]
		public CString ContextObject
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("prereqType")]
		[REDProperty(IsIgnored = true)]
		public CString PrereqType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("valueToCompare")]
		[REDProperty(IsIgnored = true)]
		public CFloat ValueToCompare
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
