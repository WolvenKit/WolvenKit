using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftDepartedEvent : redEvent
	{
		private CString _floor;

		[Ordinal(0)] 
		[RED("floor")] 
		public CString Floor
		{
			get => GetProperty(ref _floor);
			set => SetProperty(ref _floor, value);
		}
	}
}
