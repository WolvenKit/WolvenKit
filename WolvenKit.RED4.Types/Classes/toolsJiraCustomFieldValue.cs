using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsJiraCustomFieldValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
