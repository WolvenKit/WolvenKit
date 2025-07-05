using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetTrafficLaneMovementParams : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("movementType")] 
		public CString MovementType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("fearStage")] 
		public CEnum<gameFearStage> FearStage
		{
			get => GetPropertyValue<CEnum<gameFearStage>>();
			set => SetPropertyValue<CEnum<gameFearStage>>(value);
		}

		public SetTrafficLaneMovementParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
