using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRandomizerNode : scnSceneGraphNode
	{
		private CEnum<scnRandomizerMode> _mode;
		private CUInt32 _numOutSockets;
		private CArrayFixedSize<CUInt8> _weights;

		[Ordinal(3)] 
		[RED("mode")] 
		public CEnum<scnRandomizerMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(4)] 
		[RED("numOutSockets")] 
		public CUInt32 NumOutSockets
		{
			get => GetProperty(ref _numOutSockets);
			set => SetProperty(ref _numOutSockets, value);
		}

		[Ordinal(5)] 
		[RED("weights", 32)] 
		public CArrayFixedSize<CUInt8> Weights
		{
			get => GetProperty(ref _weights);
			set => SetProperty(ref _weights, value);
		}
	}
}
