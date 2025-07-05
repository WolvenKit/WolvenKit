using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraCustomFieldValue : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraCustomFieldValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
