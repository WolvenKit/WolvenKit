using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehiclePanzerBootupUIQuestEvent : redEvent
	{
		private CEnum<panzerBootupUI> _mode;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<panzerBootupUI> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}
	}
}
