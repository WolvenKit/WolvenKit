using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_Ricochet : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("outputRicochetVector")] 
		public gameEffectOutputParameter_Vector OutputRicochetVector
		{
			get => GetPropertyValue<gameEffectOutputParameter_Vector>();
			set => SetPropertyValue<gameEffectOutputParameter_Vector>(value);
		}

		public gameEffectExecutor_Ricochet()
		{
			OutputRicochetVector = new gameEffectOutputParameter_Vector { BlackboardProperty = new gameBlackboardPropertyBindingDefinition { SerializableID = new gameBlackboardSerializableID(), PropertyPath = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
