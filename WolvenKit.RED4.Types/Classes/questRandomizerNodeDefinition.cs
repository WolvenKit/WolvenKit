using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRandomizerNodeDefinition : questDisableableNodeDefinition
	{
		private CEnum<questRandomizerMode> _mode;
		private CArray<CUInt8> _outputWeights;

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<questRandomizerMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(3)] 
		[RED("outputWeights")] 
		public CArray<CUInt8> OutputWeights
		{
			get => GetProperty(ref _outputWeights);
			set => SetProperty(ref _outputWeights, value);
		}
	}
}
