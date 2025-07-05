using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFSMTransitionDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("destination")] 
		public CUInt16 Destination
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CUInt16 Condition
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public AIFSMTransitionDefinition()
		{
			Destination = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
