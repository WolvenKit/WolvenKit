
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOutput_Record
	{
		[RED("AIPriority")]
		[REDProperty(IsIgnored = true)]
		public CFloat AIPriority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("outputName")]
		[REDProperty(IsIgnored = true)]
		public CString OutputName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
