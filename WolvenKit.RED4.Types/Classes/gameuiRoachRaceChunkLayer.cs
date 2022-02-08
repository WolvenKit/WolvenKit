using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRoachRaceChunkLayer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunks")] 
		public CArray<gameuiRoachRaceChunk> Chunks
		{
			get => GetPropertyValue<CArray<gameuiRoachRaceChunk>>();
			set => SetPropertyValue<CArray<gameuiRoachRaceChunk>>(value);
		}

		public gameuiRoachRaceChunkLayer()
		{
			Chunks = new();
		}
	}
}
