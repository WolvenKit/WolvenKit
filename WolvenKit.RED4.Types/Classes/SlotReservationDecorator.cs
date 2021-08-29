using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlotReservationDecorator : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<gameMountEventData> _mountEventData;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<gameMountEventData> MountEventData
		{
			get => GetProperty(ref _mountEventData);
			set => SetProperty(ref _mountEventData, value);
		}
	}
}
