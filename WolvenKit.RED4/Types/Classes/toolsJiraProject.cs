using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsJiraProject : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CString Key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsJiraProject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
