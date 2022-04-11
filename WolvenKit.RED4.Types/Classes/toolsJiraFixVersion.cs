using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsJiraFixVersion : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
