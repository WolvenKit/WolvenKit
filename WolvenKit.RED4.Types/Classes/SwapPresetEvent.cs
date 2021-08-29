using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SwapPresetEvent : redEvent
	{
		private CString _mappingName;

		[Ordinal(0)] 
		[RED("mappingName")] 
		public CString MappingName
		{
			get => GetProperty(ref _mappingName);
			set => SetProperty(ref _mappingName, value);
		}
	}
}
