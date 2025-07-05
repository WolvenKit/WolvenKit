using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRandomizerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questRandomizerMode> Mode
		{
			get => GetPropertyValue<CEnum<questRandomizerMode>>();
			set => SetPropertyValue<CEnum<questRandomizerMode>>(value);
		}

		[Ordinal(3)] 
		[RED("outputWeights")] 
		public CArray<CUInt8> OutputWeights
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public questRandomizerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			OutputWeights = new() { 1, 1 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
