using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class panelApperanceSwitchEvent : redEvent
	{
		private CName _newApperance;

		[Ordinal(0)] 
		[RED("newApperance")] 
		public CName NewApperance
		{
			get => GetProperty(ref _newApperance);
			set => SetProperty(ref _newApperance, value);
		}
	}
}
