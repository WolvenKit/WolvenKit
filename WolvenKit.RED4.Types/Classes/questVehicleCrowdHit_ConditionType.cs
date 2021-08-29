using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleCrowdHit_ConditionType : questIVehicleConditionType
	{
		private CBool _lethal;

		[Ordinal(0)] 
		[RED("lethal")] 
		public CBool Lethal
		{
			get => GetProperty(ref _lethal);
			set => SetProperty(ref _lethal, value);
		}
	}
}
