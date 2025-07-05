using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("inputSocketCount")] 
		public CUInt32 InputSocketCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("outputSocketCount")] 
		public CUInt32 OutputSocketCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questLogicalBaseNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
