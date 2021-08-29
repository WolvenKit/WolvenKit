using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PresetTimetableEvent : redEvent
	{
		private CInt32 _arrayPosition;

		[Ordinal(0)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetProperty(ref _arrayPosition);
			set => SetProperty(ref _arrayPosition, value);
		}
	}
}
