using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestCrystalDomeEvent : redEvent
	{
		private CBool _toggle;
		private CBool _removeQuestControl;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("removeQuestControl")] 
		public CBool RemoveQuestControl
		{
			get => GetProperty(ref _removeQuestControl);
			set => SetProperty(ref _removeQuestControl, value);
		}
	}
}
