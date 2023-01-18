using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<AIbehaviorUpdateOutcome> Result
		{
			get => GetPropertyValue<CEnum<AIbehaviorUpdateOutcome>>();
			set => SetPropertyValue<CEnum<AIbehaviorUpdateOutcome>>(value);
		}

		public MountAssigendVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
