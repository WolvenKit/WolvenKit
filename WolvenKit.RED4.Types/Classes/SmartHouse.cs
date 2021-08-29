using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHouse : InteractiveMasterDevice
	{
		private CBool _timetableActive;

		[Ordinal(97)] 
		[RED("timetableActive")] 
		public CBool TimetableActive
		{
			get => GetProperty(ref _timetableActive);
			set => SetProperty(ref _timetableActive, value);
		}
	}
}
