using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimetableSetup : RedBaseClass
	{
		private CInt32 _departFrequency;
		private CInt32 _uiUpdateFrequency;

		[Ordinal(0)] 
		[RED("departFrequency")] 
		public CInt32 DepartFrequency
		{
			get => GetProperty(ref _departFrequency);
			set => SetProperty(ref _departFrequency, value);
		}

		[Ordinal(1)] 
		[RED("uiUpdateFrequency")] 
		public CInt32 UiUpdateFrequency
		{
			get => GetProperty(ref _uiUpdateFrequency);
			set => SetProperty(ref _uiUpdateFrequency, value);
		}
	}
}
