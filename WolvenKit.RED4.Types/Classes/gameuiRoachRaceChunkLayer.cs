using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceChunkLayer : RedBaseClass
	{
		private CArray<gameuiRoachRaceChunk> _chunks;

		[Ordinal(0)] 
		[RED("chunks")] 
		public CArray<gameuiRoachRaceChunk> Chunks
		{
			get => GetProperty(ref _chunks);
			set => SetProperty(ref _chunks, value);
		}
	}
}
