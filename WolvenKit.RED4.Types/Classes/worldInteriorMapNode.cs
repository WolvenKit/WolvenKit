using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInteriorMapNode : worldNode
	{
		private CUInt32 _version;
		private CUInt64 _coords;
		private SerializationDeferredDataBuffer _buffer;

		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(5)] 
		[RED("coords")] 
		public CUInt64 Coords
		{
			get => GetProperty(ref _coords);
			set => SetProperty(ref _coords, value);
		}

		[Ordinal(6)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}
	}
}
