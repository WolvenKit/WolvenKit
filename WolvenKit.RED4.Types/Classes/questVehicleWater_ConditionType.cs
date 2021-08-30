using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		private CBool _submergedOnly;
		private CBool _onEnter;

		[Ordinal(0)] 
		[RED("submergedOnly")] 
		public CBool SubmergedOnly
		{
			get => GetProperty(ref _submergedOnly);
			set => SetProperty(ref _submergedOnly, value);
		}

		[Ordinal(1)] 
		[RED("onEnter")] 
		public CBool OnEnter
		{
			get => GetProperty(ref _onEnter);
			set => SetProperty(ref _onEnter, value);
		}

		public questVehicleWater_ConditionType()
		{
			_submergedOnly = true;
			_onEnter = true;
		}
	}
}
