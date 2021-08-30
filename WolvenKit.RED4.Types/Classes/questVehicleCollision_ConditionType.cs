using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleCollision_ConditionType : questIVehicleConditionType
	{
		private CEnum<questImpulseMagnitude> _magnitude;

		[Ordinal(0)] 
		[RED("magnitude")] 
		public CEnum<questImpulseMagnitude> Magnitude
		{
			get => GetProperty(ref _magnitude);
			set => SetProperty(ref _magnitude, value);
		}

		public questVehicleCollision_ConditionType()
		{
			_magnitude = new() { Value = Enums.questImpulseMagnitude.Medium };
		}
	}
}
