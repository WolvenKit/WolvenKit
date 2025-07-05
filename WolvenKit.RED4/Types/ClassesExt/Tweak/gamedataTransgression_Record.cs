
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTransgression_Record
	{
		[RED("drawWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat DrawWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("severity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Severity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
