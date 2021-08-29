using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLogicalBaseNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CUInt32 _inputSocketCount;
		private CUInt32 _outputSocketCount;

		[Ordinal(2)] 
		[RED("inputSocketCount")] 
		public CUInt32 InputSocketCount
		{
			get => GetProperty(ref _inputSocketCount);
			set => SetProperty(ref _inputSocketCount, value);
		}

		[Ordinal(3)] 
		[RED("outputSocketCount")] 
		public CUInt32 OutputSocketCount
		{
			get => GetProperty(ref _outputSocketCount);
			set => SetProperty(ref _outputSocketCount, value);
		}
	}
}
