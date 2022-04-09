using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPlayerInVehicleASTCD : audioAudioStateTransitionConditionData
	{
		[Ordinal(1)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioPlayerInVehicleASTCD()
		{
			IsInside = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
