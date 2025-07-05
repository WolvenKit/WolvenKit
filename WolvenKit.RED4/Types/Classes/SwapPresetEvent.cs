using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SwapPresetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mappingName")] 
		public CString MappingName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SwapPresetEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
