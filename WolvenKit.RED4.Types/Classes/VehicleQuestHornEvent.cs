using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestHornEvent : redEvent
	{
		private CFloat _honkTime;

		[Ordinal(0)] 
		[RED("honkTime")] 
		public CFloat HonkTime
		{
			get => GetProperty(ref _honkTime);
			set => SetProperty(ref _honkTime, value);
		}
	}
}
