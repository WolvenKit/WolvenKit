using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwapPresetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mappingName")] 
		public CString MappingName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
